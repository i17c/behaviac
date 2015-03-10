/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Tencent is pleased to support the open source community by making behaviac available.
//
// Copyright (C) 2015 THL A29 Limited, a Tencent company. All rights reserved.
//
// Licensed under the BSD 3-Clause License (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at http://opensource.org/licenses/BSD-3-Clause
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and limitations under the License.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef _BASE_DYNAMICTYPE_H_
#define _BASE_DYNAMICTYPE_H_

#include "behaviac/base/base.h"
#include "behaviac/base/core/container/string_t.h"
#include "behaviac/base/core/container/vector_t.h"
#include "behaviac/base/core/container/list_t.h"
#include "behaviac/base/core/container/map_t.h"
#include "behaviac/base/core/container/set_t.h"

#include "behaviac/base/core/string/stringid.h"
#include "behaviac/base/core/string/formatstring.h"
#include "behaviac/base/core/crc.h"

#include "behaviac/base/meta/removeconst.h"
#include "behaviac/base/meta/removeref.h"

#include "behaviac/base/meta/types.h"


/*! This class simulates RTTI behavior where RTTI is necessary but not supported by the compiler options.
 */
class BEHAVIAC_API CDynamicType
{
public:
    BEHAVIAC_DECLARE_MEMORY_OPERATORS(CDynamicType);

protected:
    struct SHierarchyInfoBase
    {
        char const*		m_typeName;
        uint32_t		m_hierarchyLevel;  // == NumLevels.
    };

public:
    struct SHierarchyInfo : public SHierarchyInfoBase
    {
        CStringID   m_hierarchy[1];
        inline const CStringID& GetClassTypeId() const
        {
            return m_hierarchy[m_hierarchyLevel - 1];
        }
    };

protected:
    template<int NumLevels>
    struct SHierarchyInfoDecl : public SHierarchyInfoBase
    {
        friend class CDynamicType;
    protected:
        // This is to bypass initialization
        struct FakeCStringID
        {
            char m_buf[sizeof(CStringID)];
        };
        FakeCStringID	m_hierarchy[NumLevels];

    public:
        void InternalInitClassHierarchyInfo(char const* typeName, const SHierarchyInfoBase* parent_)
        {
            SHierarchyInfo*       target = reinterpret_cast< SHierarchyInfo* >(this);
            const SHierarchyInfo* parent = static_cast< const SHierarchyInfo* >(parent_);
            {
                BEHAVIAC_STATIC_ASSERT(offsetof(SHierarchyInfoDecl, m_hierarchy) == offsetof(SHierarchyInfo, m_hierarchy));
            }
            {
                BEHAVIAC_STATIC_ASSERT(sizeof(m_hierarchy[0]) == sizeof(parent->m_hierarchy[0]));
            }
            target->m_typeName = typeName;
            uint32_t parentLevel = 0;

            if (parent != NULL)
            {
                parentLevel = parent->m_hierarchyLevel;

                for (uint32_t i = 0; i < parentLevel; i++)
                {
                    target->m_hierarchy[i] = parent->m_hierarchy[i];
                }
            }

            target->m_hierarchyLevel = parentLevel + 1;
            target->m_hierarchy[parentLevel] = CStringID(typeName);
        }
        void InitClassHierarchyInfo(char const* typeName, const SHierarchyInfoBase* parent_);

    };

    static const uint32_t sm_HierarchyLevel = 0;

public:
    /// Forces derived classes to have a virtual destructor.
    virtual ~CDynamicType() {}

    virtual const SHierarchyInfo* GetHierarchyInfo() const
    {
        return NULL;
    }

    const BEHAVIAC_FORCEINLINE CStringID& GetObjectTypeId() const
    {
        return GetHierarchyInfo()->GetClassTypeId();
    }
    const BEHAVIAC_FORCEINLINE char* GetObjectTypeName() const
    {
        return GetHierarchyInfo()->m_typeName;
    }

    /*!
     * Return the Id of the leaf class.
     * It returns the real class Id of an object pointer (base class pointer to a derived class will
     * return the Id of the derived class)
     * This function must be called from an object instantiation.
     * There is also a GetClassTypeId that is static and must be called from a class point of view.
     * The DECLARE_ROOT_DYNAMIC_TYPE macro automatically implements those functions for the derived class.
     */
    //const CStringID& GetObjectTypeId() const;

    /*!
    * Return the name of the leaf class.
    * It returns the real class name of an object pointer (base class pointer to a derived class will
    * return the name of the derived class)
    * This function must be called from an object instantiation.
    * There is also a GetClassTypeName that is static and must be called from a class point of view.
    * The DECLARE_ROOT_DYNAMIC_TYPE macro automatically implements those functions for the derived class.
    */
    //const char* GetObjectTypeName() const;

    /*!
     * Looks up the class hierarchy to determine if the supplied typeId pointer is part of it.
     * The DECLARE_ROOT_DYNAMIC_TYPE macro automatically implements this function for the derived class.
     *
     * @param typeId A ptr to the static type Id string of the verified class.
     *
     * @return True if typeId is a static member of a class part of the object's hierarchy.
     */
    bool IsAKindOf(const CStringID& typeId) const
    {
        const SHierarchyInfo* info = GetHierarchyInfo();

        for (uint32_t i = 0; i < info->m_hierarchyLevel; ++i)
        {
            if (info->m_hierarchy[i] == typeId)
            {
                return true;
            }
        }

        return false;
    }

    /*!
    * Returns true if the other object can be DynamicCast to this class.
    * The DECLARE_ROOT_DYNAMIC_TYPE macro automatically implements those functions for the derived class.
    */
    //static bool IsOfMyKind( CDynamicType *other );
    //static bool IsOfMyKind( const CDynamicType *other );
    //static bool IsOfMyKind( CDynamicType & other );
    //static bool IsOfMyKind( const CDynamicType & other );

    /*!
     * Returns a pointer cast to this class if other is-a type of this class.
     * The DECLARE_ROOT_DYNAMIC_TYPE macro automatically implements this function for the derived class.
     * Example usage: Derived *derived = Derived::DynamicCast(parent);
     *     will return a valid pointer to Derived if "parent" is really a Derived. Otherwise derived will be NULL.
     *
     * @param *other A pointer to cast to this type.
     *
     * @return A pointer cast to the class or NULL if the value is not part of the hierarchy.
     */
    static CDynamicType* DynamicCast(CDynamicType* other)
    {
        return other;
    }
    static const CDynamicType* DynamicCast(const CDynamicType* other)
    {
        return other;
    }

    /*!
    * Returns a pointer cast to this class by a classic C++ static_cast.
    * An error check is done at runtime according to compilation switches.
    * Example usage: Derived *derived = Derived::StaticCast(parent);
    *     will return a pointer to Derived. If "parent" is not really a Derived it will ASSERT.
    *
    * @param *other A pointer to cast to this type.
    *
    * @return A pointer cast to the class
    *
    * ASSERT if not a valid cast.
    */
    static CDynamicType* StaticCast(CDynamicType* other)
    {
        return other;
    }
    static const CDynamicType* StaticCast(const CDynamicType* other)
    {
        return other;
    }

protected:
    // If you get a compile error about this function not being declared in
    // your derived class, you need to use the DECLARE_ROOT_DYNAMIC_TYPE macro.
    //	virtual void Use_DECLARE_DYNAMIC_TYPE_macro() = 0;

public:
    bool IsMyParent(uint32_t level, const CStringID& classId) const
    {
        const SHierarchyInfo* info = GetHierarchyInfo();
        return (level <= info->m_hierarchyLevel) && info->m_hierarchy[level - 1] == classId;
    }

    template <class T> inline static bool CallParent(T handler)
    {
        return false;
    }
};

#define BEHAVIAC_OVERRIDE_TYPE_NAME_(typeFullClassNameWithNamespace, typeName)    \
    template <> inline const char* GetClassTypeName< typeFullClassNameWithNamespace >(typeFullClassNameWithNamespace*){ return #typeName; } \
    template <> inline const char* GetClassTypeName< typeFullClassNameWithNamespace >(typeFullClassNameWithNamespace**){ return #typeName"*"; } \


//BEHAVIAC_OVERRIDE_TYPE_NAME can't be placed in a namespace
#define BEHAVIAC_OVERRIDE_TYPE_NAME(typeFullNameWithNamespace)    BEHAVIAC_OVERRIDE_TYPE_NAME_(typeFullNameWithNamespace, typeFullNameWithNamespace)
     
template<typename T>
inline const char* GetClassTypeName(T*)
{
    const char* pType = T::GetClassTypeName();
    return pType;
}

template<typename T>
inline const char* GetClassTypeName(T**)
{
    const char* pType = T::GetClassTypeName();
    return pType;
}


template<typename T>
inline behaviac::string GetTypeDescString()
{
	typedef REAL_BASETYPE(T)				RealBaseType_t;
	typedef POINTER_TYPE(RealBaseType_t)	PointerType_t;
	PointerType_t pT = (PointerType_t)0;
	behaviac::string typeResult = GetClassTypeName(pT);
	bool isConst = behaviac::Meta::IsConst<T>::Result;
	bool isPtr = behaviac::Meta::IsPtr<T>::Result;
	bool isRef = behaviac::Meta::IsRef<T>::Result;

	if (isConst)
	{
		typeResult = "const " + typeResult;
	}

	if (isPtr)
	{
		typeResult += "*";
	}

	if (isRef)
	{
		typeResult += "&";
	}

	return typeResult;
}


template<typename T>
inline const char* GetClassTypeName(behaviac::vector<T>*)
{
	const behaviac::string pType = GetTypeDescString<T>();

	static char s_buffer[256];
	const char* p = FormatString("vector<%s>", pType.c_str());
	strncpy(s_buffer, p, 256);
	return s_buffer;
}


template<typename T>
inline const char* GetClassTypeName(behaviac::list<T>*)
{
	const behaviac::string pType = GetTypeDescString<T>();

	static char s_buffer[256];
	const char* p = FormatString("list<%s>", pType.c_str());
	strncpy(s_buffer, p, 256);
	return s_buffer;
}


template<typename T, typename V>
inline const char* GetClassTypeName(behaviac::map<T, V>*)
{
	const behaviac::string pKeyType = GetTypeDescString<T>();
	const behaviac::string pValueType = GetTypeDescString<V>();

	const char* p = FormatString("map<%s, %s>", pKeyType.c_str(), pValueType.c_str());

	static char s_buffer[256];
	strncpy(s_buffer, p, 256);
	return s_buffer;
}

template<typename T>
inline const char* GetClassTypeName(behaviac::set_t<T>*)
{
	const behaviac::string pKeyType = GetTypeDescString<T>();

    const char* p = FormatString("set<%s>", pKeyType.c_str());

	static char s_buffer[256];
	strncpy(s_buffer, p, 256);
	return s_buffer;
}


template < typename T, bool bAgent >
struct GetClassTypeNumberIdSelector
{
	static int GetClassTypeNumberId()
	{
		const char* typeName = ::GetClassTypeName((T*)0);
		return CRC32::CalcCRC(typeName);
	}
};


template < typename T >
struct GetClassTypeNumberIdSelector<T, true>
{
	static int GetClassTypeNumberId()
	{
		const char* typeName = "void*";
		return CRC32::CalcCRC(typeName);
	}
};


template<typename T>
inline int GetClassTypeNumberId()
{
	int ret = GetClassTypeNumberIdSelector<T, behaviac::Meta::IsAgent<T>::Result>::GetClassTypeNumberId();

	return ret;
}


#ifdef _DEBUG
template <class T> class CTemplateClassDetector {};

template <typename T1, template <typename> class TClass>
class CTemplateClassDetector< TClass<T1> >
{
    typename TClass<T1>::You_are_using_the_wrong_macro__use__BEHAVIAC_DECLARE_TEMPLATE_DYNAMIC_TYPE1__instead m_member;
};

template <typename T1, typename T2, template <typename, typename> class TClass>
class CTemplateClassDetector< TClass<T1, T2> >
{
    typename TClass<T1, T2>::You_are_using_the_wrong_macro__use__BEHAVIAC_DECLARE_TEMPLATE_DYNAMIC_TYPE2__instead m_member;
};

template <typename T1, typename T2, typename T3, template <typename, typename, typename> class TClass>
class CTemplateClassDetector< TClass<T1, T2, T3> >
{
    typename TClass<T1, T2, T3>::You_are_using_the_wrong_macro__use__BEHAVIAC_DECLARE_TEMPLATE_DYNAMIC_TYPE3__instead m_member;
};

template <typename T1, typename T2, typename T3, typename T4, template <typename, typename, typename, typename> class TClass>
class CTemplateClassDetector< TClass<T1, T2, T3, T4> >
{
    typename TClass<T1, T2, T3, T4>::You_are_using_the_wrong_macro__use__BEHAVIAC_DECLARE_TEMPLATE_DYNAMIC_TYPE4__instead m_member;
};

template <typename T1, typename T2, typename T3, typename T4, typename T5, template <typename, typename, typename, typename, typename> class TClass>
class CTemplateClassDetector< TClass<T1, T2, T3, T4, T5> >
{
    typename TClass<T1, T2, T3, T4, T5>::You_are_using_the_wrong_macro__use__BEHAVIAC_DECLARE_TEMPLATE_DYNAMIC_TYPE5__instead m_member;
};

#define BEHAVIAC_INTERNAL_DECLARE_DYNAMIC_TYPE_COMPOSER(__type) \
    public: \
    static const char* GetClassTypeName() \
    { \
        /* If this does not compile, it means you are using a templated class with */ \
        /* the non-templated version of the dynamic type macro. */ \
        CTemplateClassDetector< __type > templateClassDetector; \
        BEHAVIAC_UNUSED_VAR(templateClassDetector); \
        \
        return #__type; \
    }

#else  // #ifdef _DEBUG

#define BEHAVIAC_INTERNAL_DECLARE_DYNAMIC_TYPE_COMPOSER(__type) \
    public: \
    static const char* GetClassTypeName() \
    { \
        return #__type; \
    }

#endif  // #ifdef _DEBUG

BEHAVIAC_API char* GenerateString1(const char* aT1, const char* aT2);
BEHAVIAC_API char* GenerateString2(const char* aT1, const char* aT2, const char* aT3);
BEHAVIAC_API char* GenerateString3(const char* aT1, const char* aT2, const char* aT3, const char* aT4);
BEHAVIAC_API char* GenerateString4(const char* aT1, const char* aT2, const char* aT3, const char* aT4, const char* aT5);
BEHAVIAC_API char* GenerateString5(const char* aT1, const char* aT2, const char* aT3, const char* aT4, const char* aT5, const char* aT6);

class CDynamicTypeAutoFreeChar
{
public:
    CDynamicTypeAutoFreeChar(char* str)	: m_str(str) {}
    BEHAVIAC_API ~CDynamicTypeAutoFreeChar();
    char* m_str;
};

#define BEHAVIAC_INTERNAL_DECLARE_TEMPLATE_DYNAMIC_TYPE_COMPOSER1(__type, ARG1) \
    public: \
    static const char* GetClassTypeName() \
    { \
        static CDynamicTypeAutoFreeChar typeName(GenerateString1(#__type, ::GetClassTypeName((ARG1*)0))); \
        return typeName.m_str; \
    }

#define BEHAVIAC_INTERNAL_DECLARE_TEMPLATE_DYNAMIC_TYPE_COMPOSER2(__type, ARG1, ARG2) \
    public: \
    static const char* GetClassTypeName() \
    { \
        static CDynamicTypeAutoFreeChar typeName(GenerateString2(#__type, ::GetClassTypeName((ARG1*)0), ::GetClassTypeName((ARG2*)0))); \
        return typeName.m_str; \
    }

#define BEHAVIAC_INTERNAL_DECLARE_TEMPLATE_DYNAMIC_TYPE_COMPOSER3(__type, ARG1, ARG2, ARG3) \
    public: \
    static const char* GetClassTypeName() \
    { \
        static CDynamicTypeAutoFreeChar typeName(GenerateString3(#__type, ::GetClassTypeName((ARG1*)0), ::GetClassTypeName((ARG2*)0), ::GetClassTypeName((ARG3*)0))); \
        return typeName.m_str; \
    }

#define BEHAVIAC_INTERNAL_DECLARE_TEMPLATE_DYNAMIC_TYPE_COMPOSER4(__type, ARG1, ARG2, ARG3, ARG4) \
    public: \
    static const char* GetClassTypeName() \
    { \
        static CDynamicTypeAutoFreeChar typeName(GenerateString4(#__type, ::GetClassTypeName((ARG1*)0), ::GetClassTypeName((ARG2*)0), ::GetClassTypeName((ARG3*)0), ::GetClassTypeName((ARG4*)0))); \
        return typeName.m_str; \
    }

#define BEHAVIAC_INTERNAL_DECLARE_TEMPLATE_DYNAMIC_TYPE_COMPOSER5(__type, ARG1, ARG2, ARG3, ARG4, ARG5) \
    public: \
    static const char* GetClassTypeName() \
    { \
        static CDynamicTypeAutoFreeChar typeName(GenerateString5(#__type, ::GetClassTypeName((ARG1*)0), ::GetClassTypeName((ARG2*)0), ::GetClassTypeName((ARG3*)0), ::GetClassTypeName((ARG4*)0), ::GetClassTypeName((ARG5*)0))); \
        return typeName.m_str(); \
    }



/*!
*  Declare a dynamic type abstract template; MUST be declared in a DynamicType derived template.
*  This macro does not need clients to put BEHAVIAC_IMPLEMENT_DYNAMIC_TYPE_* somewhere
*  in their .cpp files. Only put it in your template and you're done.
*
*  @param __template Name of the class
*  @param ARG1 Name of the template argument in the class
*  @param __parent The name of the parent class/template.
*/
#define BEHAVIAC_DECLARE_TEMPLATE_DYNAMIC_TYPE1(__template, ARG1, __parent) \
    BEHAVIAC_INTERNAL_DECLARE_TEMPLATE_DYNAMIC_TYPE_COMPOSER1(__template, ARG1); \
    BEHAVIAC_INTERNAL_DECLARE_DYNAMIC_PUBLIC_METHODES(__template, __parent);

#define BEHAVIAC_DECLARE_TEMPLATE_DYNAMIC_TYPE2(__template, ARG1,ARG2, __parent) \
    BEHAVIAC_INTERNAL_DECLARE_TEMPLATE_DYNAMIC_TYPE_COMPOSER2(__template, ARG1, ARG2); \
    BEHAVIAC_INTERNAL_DECLARE_DYNAMIC_PUBLIC_METHODES(__template, __parent);

#define BEHAVIAC_DECLARE_TEMPLATE_DYNAMIC_TYPE3(__template, ARG1,ARG2, ARG3, __parent) \
    BEHAVIAC_INTERNAL_DECLARE_TEMPLATE_DYNAMIC_TYPE_COMPOSER3(__template, ARG1, ARG2, ARG3); \
    BEHAVIAC_INTERNAL_DECLARE_DYNAMIC_PUBLIC_METHODES(__template, __parent);

#define BEHAVIAC_DECLARE_TEMPLATE_DYNAMIC_TYPE4(__template, ARG1,ARG2,ARG3,ARG4, __parent) \
    BEHAVIAC_INTERNAL_DECLARE_TEMPLATE_DYNAMIC_TYPE_COMPOSER4(__template, ARG1, ARG2,ARG3,ARG4); \
    BEHAVIAC_INTERNAL_DECLARE_DYNAMIC_PUBLIC_METHODES(__template, __parent);

#define BEHAVIAC_DECLARE_TEMPLATE_DYNAMIC_TYPE5(__template, ARG1,ARG2,ARG3,ARG4,ARG5, __parent) \
    BEHAVIAC_INTERNAL_DECLARE_TEMPLATE_DYNAMIC_TYPE_COMPOSER5(__template, ARG1, ARG2,ARG3, ARG4, ARG5); \
    BEHAVIAC_INTERNAL_DECLARE_DYNAMIC_PUBLIC_METHODES(__template, __parent);


#define BEHAVIAC_INTERNAL_DECLARE_DYNAMIC_PUBLIC_METHODES(__type, __parent) \
    protected: \
    static const uint32_t sm_HierarchyLevel = __parent::sm_HierarchyLevel + 1; \
    \
    static BEHAVIAC_FORCEINLINE CDynamicType::SHierarchyInfoDecl< sm_HierarchyLevel >* GetClassHierarchyInfoDecl() \
    { \
        static CDynamicType::SHierarchyInfoDecl< sm_HierarchyLevel > sm_HierarchyInfo; \
        return &sm_HierarchyInfo; \
    } \
    public: \
    typedef __parent super; \
    /* NOTE: implementations of GetHierarchyInfo() MUST NOT depend on the 'this' param. */ \
    /* As part of a size optim, we call it statically from other funcs, with invalid 'this'. */ \
    virtual BEHAVIAC_FORCEINLINE const CDynamicType::SHierarchyInfo* GetHierarchyInfo() const \
    { \
        CDynamicType::SHierarchyInfoDecl< sm_HierarchyLevel >* decl = GetClassHierarchyInfoDecl(); \
        if (!decl->m_typeName) decl->InitClassHierarchyInfo( \
                                                                 __type::GetClassTypeName(), __parent::GetHierarchyInfo()); \
        return (const CDynamicType::SHierarchyInfo*)decl; \
    } \
    static /*BEHAVIAC_FORCEINLINE*/ const CStringID& GetClassTypeId() \
    { \
        CDynamicType::SHierarchyInfoDecl< sm_HierarchyLevel >* decl = GetClassHierarchyInfoDecl(); \
        if (!decl->m_typeName) ((const __type*)NULL)->__type::GetHierarchyInfo(); \
        return ((const CDynamicType::SHierarchyInfo*)decl)->m_hierarchy[__type::sm_HierarchyLevel-1]; \
    } \
    static bool IsClassAKindOf(const CStringID& typeId) \
    { \
        const CDynamicType::SHierarchyInfoDecl< sm_HierarchyLevel >* decl = GetClassHierarchyInfoDecl(); \
        if (!decl->m_typeName) ((const __type*)NULL)->__type::GetHierarchyInfo(); \
        for(uint32_t i = 0; i < sm_HierarchyLevel; ++i) \
        { \
            if(((const CDynamicType::SHierarchyInfo*)decl)->m_hierarchy[i] == typeId) \
                return true; \
        } \
        return false; \
    } \
    static __type *DynamicCast( CDynamicType *other ) \
    { \
        if( other != NULL && other->IsMyParent(__type::sm_HierarchyLevel,__type::GetClassTypeId()) ) \
        { \
            return static_cast< __type * >( other ); \
        } \
        return NULL; \
    } \
    static const __type *DynamicCast( const CDynamicType *other ) \
    { \
        if( other != NULL && other->IsMyParent(__type::sm_HierarchyLevel,__type::GetClassTypeId()) ) \
        { \
            return static_cast< const __type * >( other ); \
        } \
        return NULL; \
    } \
    static __type *StaticCast( CDynamicType *other ) \
    { \
        BEHAVIAC_ASSERT(!other || DynamicCast(other));\
        return static_cast< __type * >( other ); \
    } \
    static const __type *StaticCast( const CDynamicType *other ) \
    { \
        BEHAVIAC_ASSERT(!other || DynamicCast(other));\
        return static_cast< const __type * >( other ); \
    } \
    inline static bool IsOfMyKind( CDynamicType *other ) \
    { \
        return (DynamicCast( other ) != NULL); \
    } \
    inline static bool IsOfMyKind( const CDynamicType *other ) \
    { \
        return (DynamicCast( other ) != NULL); \
    } \
    inline static bool IsOfMyKind( CDynamicType & other ) \
    { \
        return IsOfMyKind(&other); \
    } \
    inline static bool IsOfMyKind( const CDynamicType & other ) \
    { \
        return IsOfMyKind(&other); \
    }\
    template <class __TypeOfHandler> inline static bool CallParent(__TypeOfHandler handler)\
    {\
        handler.template Call<super>();\
        return true;\
    }


/*!
 *  Declare a dynamic type abstract class; MUST be declared in a DynamicType derived class.
 *  This macro does not need clients to put IMPLEMENT_DYNAMIC_TYPE_FAST somewhere
 *  in their .cpp files. Only put it in your class and you're done.
 *
 *  @param __type   The name of this class.
 *  @param __parent The name of the parent class.
 */
#define BEHAVIAC_DECLARE_DYNAMIC_TYPE(__type, __parent) \
    BEHAVIAC_INTERNAL_DECLARE_DYNAMIC_TYPE_COMPOSER(__type); \
    BEHAVIAC_INTERNAL_DECLARE_DYNAMIC_PUBLIC_METHODES(__type, __parent);

/*!
*  Declare a dynamic type class; MUST be declared in a Root class.
*
*  @param __type   The name of this class.
*  @param __parent The name of the parent class.
*/
#define BEHAVIAC_DECLARE_ROOT_DYNAMIC_TYPE(__type, __parent) \
    BEHAVIAC_DECLARE_DYNAMIC_TYPE(__type, __parent);
//    protected: void		Use_DECLARE_DYNAMIC_TYPE_macro(){}

#define  M_PRIMITIVE_TYPES()	\
	M_PRIMITE_TYPE(bool);					\
	M_PRIMITE_TYPE(char);					\
	M_PRIMITE_TYPE(unsigned char);			\
	M_PRIMITE_TYPE(signed char);			\
	M_PRIMITE_TYPE(unsigned short);			\
	M_PRIMITE_TYPE(signed short);			\
	M_PRIMITE_TYPE(unsigned int);			\
	M_PRIMITE_TYPE(signed int);				\
	M_PRIMITE_TYPE(unsigned long);			\
	M_PRIMITE_TYPE(signed long);			\
	M_PRIMITE_TYPE(unsigned long long);		\
	M_PRIMITE_TYPE(signed long long);		\
	M_PRIMITE_TYPE(float);					\
	M_PRIMITE_TYPE(double);					\
	M_PRIMITE_TYPE(behaviac::string);		\
	M_PRIMITE_TYPE(behaviac::wstring);		\
	M_PRIMITE_TYPE(std::string);			\
	M_PRIMITE_TYPE(std::wstring);			\



//specialization of intrinsics types...
BEHAVIAC_OVERRIDE_TYPE_NAME(void);
BEHAVIAC_OVERRIDE_TYPE_NAME(const char*);


BEHAVIAC_OVERRIDE_TYPE_NAME(bool);
BEHAVIAC_OVERRIDE_TYPE_NAME(char);
BEHAVIAC_OVERRIDE_TYPE_NAME(unsigned short);
BEHAVIAC_OVERRIDE_TYPE_NAME(signed short);
BEHAVIAC_OVERRIDE_TYPE_NAME(unsigned int);
BEHAVIAC_OVERRIDE_TYPE_NAME(signed int);
BEHAVIAC_OVERRIDE_TYPE_NAME(unsigned long);
BEHAVIAC_OVERRIDE_TYPE_NAME(signed long);
BEHAVIAC_OVERRIDE_TYPE_NAME(unsigned long long);
BEHAVIAC_OVERRIDE_TYPE_NAME(signed long long);
BEHAVIAC_OVERRIDE_TYPE_NAME(float);
BEHAVIAC_OVERRIDE_TYPE_NAME(double);
BEHAVIAC_OVERRIDE_TYPE_NAME(behaviac::string);
BEHAVIAC_OVERRIDE_TYPE_NAME(behaviac::wstring);
BEHAVIAC_OVERRIDE_TYPE_NAME(std::string);
BEHAVIAC_OVERRIDE_TYPE_NAME(std::wstring);
BEHAVIAC_OVERRIDE_TYPE_NAME_(signed char, sbyte)
BEHAVIAC_OVERRIDE_TYPE_NAME_(unsigned char, ubyte)

BEHAVIAC_OVERRIDE_TYPE_NAME(const bool);
BEHAVIAC_OVERRIDE_TYPE_NAME(const char);
BEHAVIAC_OVERRIDE_TYPE_NAME(const unsigned short);
BEHAVIAC_OVERRIDE_TYPE_NAME(const signed short);
BEHAVIAC_OVERRIDE_TYPE_NAME(const unsigned int);
BEHAVIAC_OVERRIDE_TYPE_NAME(const signed int);
BEHAVIAC_OVERRIDE_TYPE_NAME(const unsigned long);
BEHAVIAC_OVERRIDE_TYPE_NAME(const signed long);
BEHAVIAC_OVERRIDE_TYPE_NAME(const unsigned long long);
BEHAVIAC_OVERRIDE_TYPE_NAME(const signed long long);
BEHAVIAC_OVERRIDE_TYPE_NAME(const float);
BEHAVIAC_OVERRIDE_TYPE_NAME(const double);
BEHAVIAC_OVERRIDE_TYPE_NAME(const behaviac::string);
BEHAVIAC_OVERRIDE_TYPE_NAME(const behaviac::wstring);
BEHAVIAC_OVERRIDE_TYPE_NAME(const std::string);
BEHAVIAC_OVERRIDE_TYPE_NAME(const std::wstring);
BEHAVIAC_OVERRIDE_TYPE_NAME_(const signed char, cosnt sbyte)
BEHAVIAC_OVERRIDE_TYPE_NAME_(const unsigned char, const ubyte)

template<> inline int GetClassTypeNumberId<bool>() {return 1;}
template<> inline int GetClassTypeNumberId<char>() {return 2;}
template<> inline int GetClassTypeNumberId<signed char>() { return 3; }
template<> inline int GetClassTypeNumberId<unsigned char>() {return 4;}
template<> inline int GetClassTypeNumberId<short>() {return 5;}
template<> inline int GetClassTypeNumberId<unsigned short>() {return 6;}
template<> inline int GetClassTypeNumberId<int>() {return 7;}
template<> inline int GetClassTypeNumberId<unsigned int>() {return 8;}
template<> inline int GetClassTypeNumberId<long>() {return 9;}
template<> inline int GetClassTypeNumberId<unsigned long>() {return 10;}
template<> inline int GetClassTypeNumberId<long long>() {return 11;}
template<> inline int GetClassTypeNumberId<unsigned long long>() {return 12;}
template<> inline int GetClassTypeNumberId<float>() {return 13;}
template<> inline int GetClassTypeNumberId<double>() {return 14;}

inline bool IsNumberClassTypeNumberId(int typeId)
{
	if (
		typeId == GetClassTypeNumberId<char>() ||
		typeId == GetClassTypeNumberId<signed char>() ||
		typeId == GetClassTypeNumberId<unsigned char>() ||
		typeId == GetClassTypeNumberId<short>() ||
		typeId == GetClassTypeNumberId<unsigned short>() ||
		typeId == GetClassTypeNumberId<int>() ||
		typeId == GetClassTypeNumberId<unsigned int>() ||
		typeId == GetClassTypeNumberId<long>() ||
		typeId == GetClassTypeNumberId<unsigned long>() ||
		typeId == GetClassTypeNumberId<long long>() ||
		typeId == GetClassTypeNumberId<unsigned long long>() ||
		typeId == GetClassTypeNumberId<float>() ||
		typeId == GetClassTypeNumberId<double>()
		)
	{
		return true;
	}

	return false;
}

template<int NumLevels>
void CDynamicType::SHierarchyInfoDecl<NumLevels>::InitClassHierarchyInfo(char const* typeName, const SHierarchyInfoBase* parent_)
{
    InternalInitClassHierarchyInfo(typeName, parent_);
}

template<> void BEHAVIAC_API CDynamicType::SHierarchyInfoDecl<1>::InitClassHierarchyInfo(char const* typeName, const CDynamicType::SHierarchyInfoBase* parent_);
template<> void BEHAVIAC_API CDynamicType::SHierarchyInfoDecl<2>::InitClassHierarchyInfo(char const* typeName, const CDynamicType::SHierarchyInfoBase* parent_);
template<> void BEHAVIAC_API CDynamicType::SHierarchyInfoDecl<3>::InitClassHierarchyInfo(char const* typeName, const CDynamicType::SHierarchyInfoBase* parent_);
template<> void BEHAVIAC_API CDynamicType::SHierarchyInfoDecl<4>::InitClassHierarchyInfo(char const* typeName, const CDynamicType::SHierarchyInfoBase* parent_);
template<> void BEHAVIAC_API CDynamicType::SHierarchyInfoDecl<5>::InitClassHierarchyInfo(char const* typeName, const CDynamicType::SHierarchyInfoBase* parent_);
template<> void BEHAVIAC_API CDynamicType::SHierarchyInfoDecl<6>::InitClassHierarchyInfo(char const* typeName, const CDynamicType::SHierarchyInfoBase* parent_);
template<> void BEHAVIAC_API CDynamicType::SHierarchyInfoDecl<7>::InitClassHierarchyInfo(char const* typeName, const CDynamicType::SHierarchyInfoBase* parent_);
template<> void BEHAVIAC_API CDynamicType::SHierarchyInfoDecl<8>::InitClassHierarchyInfo(char const* typeName, const CDynamicType::SHierarchyInfoBase* parent_);
template<> void BEHAVIAC_API CDynamicType::SHierarchyInfoDecl<9>::InitClassHierarchyInfo(char const* typeName, const CDynamicType::SHierarchyInfoBase* parent_);


#endif  // _BASE_DYNAMICTYPE_H_

