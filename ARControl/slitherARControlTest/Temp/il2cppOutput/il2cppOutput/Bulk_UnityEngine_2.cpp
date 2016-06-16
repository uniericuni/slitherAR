#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <cstring>
#include <string.h>
#include <stdio.h>
#include <cmath>
#include <limits>
#include <assert.h>

// System.Object
struct Il2CppObject;
// System.String
struct String_t;
// UnityEngine.WaitForEndOfFrame
struct WaitForEndOfFrame_t1917318876;
// UnityEngine.WaitForFixedUpdate
struct WaitForFixedUpdate_t896427542;
// UnityEngine.WaitForSeconds
struct WaitForSeconds_t1291133240;
struct WaitForSeconds_t1291133240_marshaled_pinvoke;
// UnityEngine.WebCamTexture
struct WebCamTexture_t3635181805;
// UnityEngine.WebCamDevice[]
struct WebCamDeviceU5BU5D_t699707851;
// UnityEngine.WrapperlessIcall
struct WrapperlessIcall_t4003675496;
// UnityEngine.WritableAttribute
struct WritableAttribute_t1716006665;
// UnityEngine.YieldInstruction
struct YieldInstruction_t3557331758;
struct YieldInstruction_t3557331758_marshaled_pinvoke;
// UnityEngineInternal.GenericStack
struct GenericStack_t2344941421;
// UnityEngineInternal.TypeInferenceRuleAttribute
struct TypeInferenceRuleAttribute_t471424957;

#include "class-internals.h"
#include "codegen/il2cpp-codegen.h"
#include "mscorlib_System_Array2840145358.h"
#include "UnityEngine_UnityEngine_Vector43525329790.h"
#include "UnityEngine_UnityEngine_Vector43525329790MethodDeclarations.h"
#include "mscorlib_System_Void2779279689.h"
#include "mscorlib_System_Single958209021.h"
#include "mscorlib_System_Int322847414787.h"
#include "mscorlib_System_Single958209021MethodDeclarations.h"
#include "mscorlib_System_Object837106420.h"
#include "mscorlib_System_Boolean211005341.h"
#include "mscorlib_System_String968488902.h"
#include "UnityEngine_UnityEngine_UnityString963216403MethodDeclarations.h"
#include "mscorlib_ArrayTypes.h"
#include "UnityEngine_UnityEngine_Vector33525329789.h"
#include "UnityEngine_UnityEngine_Vector33525329789MethodDeclarations.h"
#include "UnityEngine_UnityEngine_WaitForEndOfFrame1917318876.h"
#include "UnityEngine_UnityEngine_WaitForEndOfFrame1917318876MethodDeclarations.h"
#include "UnityEngine_UnityEngine_YieldInstruction3557331758MethodDeclarations.h"
#include "UnityEngine_UnityEngine_WaitForFixedUpdate896427542.h"
#include "UnityEngine_UnityEngine_WaitForFixedUpdate896427542MethodDeclarations.h"
#include "UnityEngine_UnityEngine_WaitForSeconds1291133240.h"
#include "UnityEngine_UnityEngine_WaitForSeconds1291133240MethodDeclarations.h"
#include "UnityEngine_UnityEngine_WebCamDevice1687076478.h"
#include "UnityEngine_UnityEngine_WebCamDevice1687076478MethodDeclarations.h"
#include "UnityEngine_UnityEngine_WebCamTexture3635181805.h"
#include "UnityEngine_UnityEngine_WebCamTexture3635181805MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Texture1769722184MethodDeclarations.h"
#include "mscorlib_System_String968488902MethodDeclarations.h"
#include "UnityEngine_ArrayTypes.h"
#include "UnityEngine_UnityEngine_WrapperlessIcall4003675496.h"
#include "UnityEngine_UnityEngine_WrapperlessIcall4003675496MethodDeclarations.h"
#include "mscorlib_System_Attribute498693649MethodDeclarations.h"
#include "UnityEngine_UnityEngine_WritableAttribute1716006665.h"
#include "UnityEngine_UnityEngine_WritableAttribute1716006665MethodDeclarations.h"
#include "UnityEngine_UnityEngine_YieldInstruction3557331758.h"
#include "mscorlib_System_Object837106420MethodDeclarations.h"
#include "UnityEngine_UnityEngineInternal_GenericStack2344941421.h"
#include "UnityEngine_UnityEngineInternal_GenericStack2344941421MethodDeclarations.h"
#include "mscorlib_System_Collections_Stack1623036922MethodDeclarations.h"
#include "UnityEngine_UnityEngineInternal_MathfInternal681132919.h"
#include "UnityEngine_UnityEngineInternal_MathfInternal681132919MethodDeclarations.h"
#include "UnityEngine_UnityEngineInternal_TypeInferenceRuleAt471424957.h"
#include "UnityEngine_UnityEngineInternal_TypeInferenceRuleAt471424957MethodDeclarations.h"
#include "UnityEngine_UnityEngineInternal_TypeInferenceRules435505844.h"
#include "mscorlib_System_Enum2778772662MethodDeclarations.h"
#include "mscorlib_System_Enum2778772662.h"
#include "UnityEngine_UnityEngineInternal_TypeInferenceRules435505844MethodDeclarations.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Vector4::.ctor(System.Single,System.Single,System.Single,System.Single)
extern "C"  void Vector4__ctor_m2441427762 (Vector4_t3525329790 * __this, float ___x0, float ___y1, float ___z2, float ___w3, const MethodInfo* method)
{
	{
		float L_0 = ___x0;
		__this->set_x_1(L_0);
		float L_1 = ___y1;
		__this->set_y_2(L_1);
		float L_2 = ___z2;
		__this->set_z_3(L_2);
		float L_3 = ___w3;
		__this->set_w_4(L_3);
		return;
	}
}
// System.Int32 UnityEngine.Vector4::GetHashCode()
extern "C"  int32_t Vector4_GetHashCode_m3402333527 (Vector4_t3525329790 * __this, const MethodInfo* method)
{
	{
		float* L_0 = __this->get_address_of_x_1();
		int32_t L_1 = Single_GetHashCode_m65342520(L_0, /*hidden argument*/NULL);
		float* L_2 = __this->get_address_of_y_2();
		int32_t L_3 = Single_GetHashCode_m65342520(L_2, /*hidden argument*/NULL);
		float* L_4 = __this->get_address_of_z_3();
		int32_t L_5 = Single_GetHashCode_m65342520(L_4, /*hidden argument*/NULL);
		float* L_6 = __this->get_address_of_w_4();
		int32_t L_7 = Single_GetHashCode_m65342520(L_6, /*hidden argument*/NULL);
		return ((int32_t)((int32_t)((int32_t)((int32_t)((int32_t)((int32_t)L_1^(int32_t)((int32_t)((int32_t)L_3<<(int32_t)2))))^(int32_t)((int32_t)((int32_t)L_5>>(int32_t)2))))^(int32_t)((int32_t)((int32_t)L_7>>(int32_t)1))));
	}
}
// System.Boolean UnityEngine.Vector4::Equals(System.Object)
extern Il2CppClass* Vector4_t3525329790_il2cpp_TypeInfo_var;
extern const uint32_t Vector4_Equals_m3270185343_MetadataUsageId;
extern "C"  bool Vector4_Equals_m3270185343 (Vector4_t3525329790 * __this, Il2CppObject * ___other0, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (Vector4_Equals_m3270185343_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	Vector4_t3525329790  V_0;
	memset(&V_0, 0, sizeof(V_0));
	int32_t G_B7_0 = 0;
	{
		Il2CppObject * L_0 = ___other0;
		if (((Il2CppObject *)IsInstSealed(L_0, Vector4_t3525329790_il2cpp_TypeInfo_var)))
		{
			goto IL_000d;
		}
	}
	{
		return (bool)0;
	}

IL_000d:
	{
		Il2CppObject * L_1 = ___other0;
		V_0 = ((*(Vector4_t3525329790 *)((Vector4_t3525329790 *)UnBox (L_1, Vector4_t3525329790_il2cpp_TypeInfo_var))));
		float* L_2 = __this->get_address_of_x_1();
		float L_3 = (&V_0)->get_x_1();
		bool L_4 = Single_Equals_m2110115959(L_2, L_3, /*hidden argument*/NULL);
		if (!L_4)
		{
			goto IL_006d;
		}
	}
	{
		float* L_5 = __this->get_address_of_y_2();
		float L_6 = (&V_0)->get_y_2();
		bool L_7 = Single_Equals_m2110115959(L_5, L_6, /*hidden argument*/NULL);
		if (!L_7)
		{
			goto IL_006d;
		}
	}
	{
		float* L_8 = __this->get_address_of_z_3();
		float L_9 = (&V_0)->get_z_3();
		bool L_10 = Single_Equals_m2110115959(L_8, L_9, /*hidden argument*/NULL);
		if (!L_10)
		{
			goto IL_006d;
		}
	}
	{
		float* L_11 = __this->get_address_of_w_4();
		float L_12 = (&V_0)->get_w_4();
		bool L_13 = Single_Equals_m2110115959(L_11, L_12, /*hidden argument*/NULL);
		G_B7_0 = ((int32_t)(L_13));
		goto IL_006e;
	}

IL_006d:
	{
		G_B7_0 = 0;
	}

IL_006e:
	{
		return (bool)G_B7_0;
	}
}
// System.String UnityEngine.Vector4::ToString()
extern Il2CppClass* ObjectU5BU5D_t11523773_il2cpp_TypeInfo_var;
extern Il2CppClass* Single_t958209021_il2cpp_TypeInfo_var;
extern Il2CppCodeGenString* _stringLiteral843281963;
extern const uint32_t Vector4_ToString_m3272970053_MetadataUsageId;
extern "C"  String_t* Vector4_ToString_m3272970053 (Vector4_t3525329790 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (Vector4_ToString_m3272970053_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	{
		ObjectU5BU5D_t11523773* L_0 = ((ObjectU5BU5D_t11523773*)SZArrayNew(ObjectU5BU5D_t11523773_il2cpp_TypeInfo_var, (uint32_t)4));
		float L_1 = __this->get_x_1();
		float L_2 = L_1;
		Il2CppObject * L_3 = Box(Single_t958209021_il2cpp_TypeInfo_var, &L_2);
		NullCheck(L_0);
		IL2CPP_ARRAY_BOUNDS_CHECK(L_0, 0);
		ArrayElementTypeCheck (L_0, L_3);
		(L_0)->SetAt(static_cast<il2cpp_array_size_t>(0), (Il2CppObject *)L_3);
		ObjectU5BU5D_t11523773* L_4 = L_0;
		float L_5 = __this->get_y_2();
		float L_6 = L_5;
		Il2CppObject * L_7 = Box(Single_t958209021_il2cpp_TypeInfo_var, &L_6);
		NullCheck(L_4);
		IL2CPP_ARRAY_BOUNDS_CHECK(L_4, 1);
		ArrayElementTypeCheck (L_4, L_7);
		(L_4)->SetAt(static_cast<il2cpp_array_size_t>(1), (Il2CppObject *)L_7);
		ObjectU5BU5D_t11523773* L_8 = L_4;
		float L_9 = __this->get_z_3();
		float L_10 = L_9;
		Il2CppObject * L_11 = Box(Single_t958209021_il2cpp_TypeInfo_var, &L_10);
		NullCheck(L_8);
		IL2CPP_ARRAY_BOUNDS_CHECK(L_8, 2);
		ArrayElementTypeCheck (L_8, L_11);
		(L_8)->SetAt(static_cast<il2cpp_array_size_t>(2), (Il2CppObject *)L_11);
		ObjectU5BU5D_t11523773* L_12 = L_8;
		float L_13 = __this->get_w_4();
		float L_14 = L_13;
		Il2CppObject * L_15 = Box(Single_t958209021_il2cpp_TypeInfo_var, &L_14);
		NullCheck(L_12);
		IL2CPP_ARRAY_BOUNDS_CHECK(L_12, 3);
		ArrayElementTypeCheck (L_12, L_15);
		(L_12)->SetAt(static_cast<il2cpp_array_size_t>(3), (Il2CppObject *)L_15);
		String_t* L_16 = UnityString_Format_m427603113(NULL /*static, unused*/, _stringLiteral843281963, L_12, /*hidden argument*/NULL);
		return L_16;
	}
}
// UnityEngine.Vector3 UnityEngine.Vector4::op_Implicit(UnityEngine.Vector4)
extern "C"  Vector3_t3525329789  Vector4_op_Implicit_m3933247893 (Il2CppObject * __this /* static, unused */, Vector4_t3525329790  ___v0, const MethodInfo* method)
{
	{
		float L_0 = (&___v0)->get_x_1();
		float L_1 = (&___v0)->get_y_2();
		float L_2 = (&___v0)->get_z_3();
		Vector3_t3525329789  L_3;
		memset(&L_3, 0, sizeof(L_3));
		Vector3__ctor_m2926210380(&L_3, L_0, L_1, L_2, /*hidden argument*/NULL);
		return L_3;
	}
}
// Conversion methods for marshalling of: UnityEngine.Vector4
extern "C" void Vector4_t3525329790_marshal_pinvoke(const Vector4_t3525329790& unmarshaled, Vector4_t3525329790_marshaled_pinvoke& marshaled)
{
	marshaled.___x_1 = unmarshaled.get_x_1();
	marshaled.___y_2 = unmarshaled.get_y_2();
	marshaled.___z_3 = unmarshaled.get_z_3();
	marshaled.___w_4 = unmarshaled.get_w_4();
}
extern "C" void Vector4_t3525329790_marshal_pinvoke_back(const Vector4_t3525329790_marshaled_pinvoke& marshaled, Vector4_t3525329790& unmarshaled)
{
	float unmarshaled_x_temp = 0.0f;
	unmarshaled_x_temp = marshaled.___x_1;
	unmarshaled.set_x_1(unmarshaled_x_temp);
	float unmarshaled_y_temp = 0.0f;
	unmarshaled_y_temp = marshaled.___y_2;
	unmarshaled.set_y_2(unmarshaled_y_temp);
	float unmarshaled_z_temp = 0.0f;
	unmarshaled_z_temp = marshaled.___z_3;
	unmarshaled.set_z_3(unmarshaled_z_temp);
	float unmarshaled_w_temp = 0.0f;
	unmarshaled_w_temp = marshaled.___w_4;
	unmarshaled.set_w_4(unmarshaled_w_temp);
}
// Conversion method for clean up from marshalling of: UnityEngine.Vector4
extern "C" void Vector4_t3525329790_marshal_pinvoke_cleanup(Vector4_t3525329790_marshaled_pinvoke& marshaled)
{
}
// Conversion methods for marshalling of: UnityEngine.Vector4
extern "C" void Vector4_t3525329790_marshal_com(const Vector4_t3525329790& unmarshaled, Vector4_t3525329790_marshaled_com& marshaled)
{
	marshaled.___x_1 = unmarshaled.get_x_1();
	marshaled.___y_2 = unmarshaled.get_y_2();
	marshaled.___z_3 = unmarshaled.get_z_3();
	marshaled.___w_4 = unmarshaled.get_w_4();
}
extern "C" void Vector4_t3525329790_marshal_com_back(const Vector4_t3525329790_marshaled_com& marshaled, Vector4_t3525329790& unmarshaled)
{
	float unmarshaled_x_temp = 0.0f;
	unmarshaled_x_temp = marshaled.___x_1;
	unmarshaled.set_x_1(unmarshaled_x_temp);
	float unmarshaled_y_temp = 0.0f;
	unmarshaled_y_temp = marshaled.___y_2;
	unmarshaled.set_y_2(unmarshaled_y_temp);
	float unmarshaled_z_temp = 0.0f;
	unmarshaled_z_temp = marshaled.___z_3;
	unmarshaled.set_z_3(unmarshaled_z_temp);
	float unmarshaled_w_temp = 0.0f;
	unmarshaled_w_temp = marshaled.___w_4;
	unmarshaled.set_w_4(unmarshaled_w_temp);
}
// Conversion method for clean up from marshalling of: UnityEngine.Vector4
extern "C" void Vector4_t3525329790_marshal_com_cleanup(Vector4_t3525329790_marshaled_com& marshaled)
{
}
// System.Void UnityEngine.WaitForEndOfFrame::.ctor()
extern "C"  void WaitForEndOfFrame__ctor_m4124201226 (WaitForEndOfFrame_t1917318876 * __this, const MethodInfo* method)
{
	{
		YieldInstruction__ctor_m539393484(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.WaitForFixedUpdate::.ctor()
extern "C"  void WaitForFixedUpdate__ctor_m2916734308 (WaitForFixedUpdate_t896427542 * __this, const MethodInfo* method)
{
	{
		YieldInstruction__ctor_m539393484(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.WaitForSeconds::.ctor(System.Single)
extern "C"  void WaitForSeconds__ctor_m3184996201 (WaitForSeconds_t1291133240 * __this, float ___seconds0, const MethodInfo* method)
{
	{
		YieldInstruction__ctor_m539393484(__this, /*hidden argument*/NULL);
		float L_0 = ___seconds0;
		__this->set_m_Seconds_0(L_0);
		return;
	}
}
// Conversion methods for marshalling of: UnityEngine.WaitForSeconds
extern "C" void WaitForSeconds_t1291133240_marshal_pinvoke(const WaitForSeconds_t1291133240& unmarshaled, WaitForSeconds_t1291133240_marshaled_pinvoke& marshaled)
{
	marshaled.___m_Seconds_0 = unmarshaled.get_m_Seconds_0();
}
extern "C" void WaitForSeconds_t1291133240_marshal_pinvoke_back(const WaitForSeconds_t1291133240_marshaled_pinvoke& marshaled, WaitForSeconds_t1291133240& unmarshaled)
{
	float unmarshaled_m_Seconds_temp = 0.0f;
	unmarshaled_m_Seconds_temp = marshaled.___m_Seconds_0;
	unmarshaled.set_m_Seconds_0(unmarshaled_m_Seconds_temp);
}
// Conversion method for clean up from marshalling of: UnityEngine.WaitForSeconds
extern "C" void WaitForSeconds_t1291133240_marshal_pinvoke_cleanup(WaitForSeconds_t1291133240_marshaled_pinvoke& marshaled)
{
}
// Conversion methods for marshalling of: UnityEngine.WaitForSeconds
extern "C" void WaitForSeconds_t1291133240_marshal_com(const WaitForSeconds_t1291133240& unmarshaled, WaitForSeconds_t1291133240_marshaled_com& marshaled)
{
	marshaled.___m_Seconds_0 = unmarshaled.get_m_Seconds_0();
}
extern "C" void WaitForSeconds_t1291133240_marshal_com_back(const WaitForSeconds_t1291133240_marshaled_com& marshaled, WaitForSeconds_t1291133240& unmarshaled)
{
	float unmarshaled_m_Seconds_temp = 0.0f;
	unmarshaled_m_Seconds_temp = marshaled.___m_Seconds_0;
	unmarshaled.set_m_Seconds_0(unmarshaled_m_Seconds_temp);
}
// Conversion method for clean up from marshalling of: UnityEngine.WaitForSeconds
extern "C" void WaitForSeconds_t1291133240_marshal_com_cleanup(WaitForSeconds_t1291133240_marshaled_com& marshaled)
{
}
// System.String UnityEngine.WebCamDevice::get_name()
extern "C"  String_t* WebCamDevice_get_name_m2875559007 (WebCamDevice_t1687076478 * __this, const MethodInfo* method)
{
	{
		String_t* L_0 = __this->get_m_Name_0();
		return L_0;
	}
}
// Conversion methods for marshalling of: UnityEngine.WebCamDevice
extern "C" void WebCamDevice_t1687076478_marshal_pinvoke(const WebCamDevice_t1687076478& unmarshaled, WebCamDevice_t1687076478_marshaled_pinvoke& marshaled)
{
	marshaled.___m_Name_0 = il2cpp_codegen_marshal_string(unmarshaled.get_m_Name_0());
	marshaled.___m_Flags_1 = unmarshaled.get_m_Flags_1();
}
extern "C" void WebCamDevice_t1687076478_marshal_pinvoke_back(const WebCamDevice_t1687076478_marshaled_pinvoke& marshaled, WebCamDevice_t1687076478& unmarshaled)
{
	unmarshaled.set_m_Name_0(il2cpp_codegen_marshal_string_result(marshaled.___m_Name_0));
	int32_t unmarshaled_m_Flags_temp = 0;
	unmarshaled_m_Flags_temp = marshaled.___m_Flags_1;
	unmarshaled.set_m_Flags_1(unmarshaled_m_Flags_temp);
}
// Conversion method for clean up from marshalling of: UnityEngine.WebCamDevice
extern "C" void WebCamDevice_t1687076478_marshal_pinvoke_cleanup(WebCamDevice_t1687076478_marshaled_pinvoke& marshaled)
{
	il2cpp_codegen_marshal_free(marshaled.___m_Name_0);
	marshaled.___m_Name_0 = NULL;
}
// Conversion methods for marshalling of: UnityEngine.WebCamDevice
extern "C" void WebCamDevice_t1687076478_marshal_com(const WebCamDevice_t1687076478& unmarshaled, WebCamDevice_t1687076478_marshaled_com& marshaled)
{
	marshaled.___m_Name_0 = il2cpp_codegen_marshal_bstring(unmarshaled.get_m_Name_0());
	marshaled.___m_Flags_1 = unmarshaled.get_m_Flags_1();
}
extern "C" void WebCamDevice_t1687076478_marshal_com_back(const WebCamDevice_t1687076478_marshaled_com& marshaled, WebCamDevice_t1687076478& unmarshaled)
{
	unmarshaled.set_m_Name_0(il2cpp_codegen_marshal_bstring_result(marshaled.___m_Name_0));
	int32_t unmarshaled_m_Flags_temp = 0;
	unmarshaled_m_Flags_temp = marshaled.___m_Flags_1;
	unmarshaled.set_m_Flags_1(unmarshaled_m_Flags_temp);
}
// Conversion method for clean up from marshalling of: UnityEngine.WebCamDevice
extern "C" void WebCamDevice_t1687076478_marshal_com_cleanup(WebCamDevice_t1687076478_marshaled_com& marshaled)
{
	il2cpp_codegen_marshal_free_bstring(marshaled.___m_Name_0);
	marshaled.___m_Name_0 = NULL;
}
// System.Void UnityEngine.WebCamTexture::.ctor()
extern Il2CppClass* String_t_il2cpp_TypeInfo_var;
extern const uint32_t WebCamTexture__ctor_m755637529_MetadataUsageId;
extern "C"  void WebCamTexture__ctor_m755637529 (WebCamTexture_t3635181805 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (WebCamTexture__ctor_m755637529_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	{
		Texture__ctor_m516856734(__this, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		String_t* L_0 = ((String_t_StaticFields*)String_t_il2cpp_TypeInfo_var->static_fields)->get_Empty_2();
		WebCamTexture_Internal_CreateWebCamTexture_m384251711(NULL /*static, unused*/, __this, L_0, 0, 0, 0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.WebCamTexture::Internal_CreateWebCamTexture(UnityEngine.WebCamTexture,System.String,System.Int32,System.Int32,System.Int32)
extern "C"  void WebCamTexture_Internal_CreateWebCamTexture_m384251711 (Il2CppObject * __this /* static, unused */, WebCamTexture_t3635181805 * ___self0, String_t* ___scriptingDevice1, int32_t ___requestedWidth2, int32_t ___requestedHeight3, int32_t ___maxFramerate4, const MethodInfo* method)
{
	typedef void (*WebCamTexture_Internal_CreateWebCamTexture_m384251711_ftn) (WebCamTexture_t3635181805 *, String_t*, int32_t, int32_t, int32_t);
	static WebCamTexture_Internal_CreateWebCamTexture_m384251711_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (WebCamTexture_Internal_CreateWebCamTexture_m384251711_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.WebCamTexture::Internal_CreateWebCamTexture(UnityEngine.WebCamTexture,System.String,System.Int32,System.Int32,System.Int32)");
	_il2cpp_icall_func(___self0, ___scriptingDevice1, ___requestedWidth2, ___requestedHeight3, ___maxFramerate4);
}
// System.Void UnityEngine.WebCamTexture::Play()
extern "C"  void WebCamTexture_Play_m2252445503 (WebCamTexture_t3635181805 * __this, const MethodInfo* method)
{
	{
		WebCamTexture_INTERNAL_CALL_Play_m3478980075(NULL /*static, unused*/, __this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.WebCamTexture::INTERNAL_CALL_Play(UnityEngine.WebCamTexture)
extern "C"  void WebCamTexture_INTERNAL_CALL_Play_m3478980075 (Il2CppObject * __this /* static, unused */, WebCamTexture_t3635181805 * ___self0, const MethodInfo* method)
{
	typedef void (*WebCamTexture_INTERNAL_CALL_Play_m3478980075_ftn) (WebCamTexture_t3635181805 *);
	static WebCamTexture_INTERNAL_CALL_Play_m3478980075_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (WebCamTexture_INTERNAL_CALL_Play_m3478980075_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.WebCamTexture::INTERNAL_CALL_Play(UnityEngine.WebCamTexture)");
	_il2cpp_icall_func(___self0);
}
// System.Void UnityEngine.WebCamTexture::Stop()
extern "C"  void WebCamTexture_Stop_m2346129549 (WebCamTexture_t3635181805 * __this, const MethodInfo* method)
{
	{
		WebCamTexture_INTERNAL_CALL_Stop_m3733059677(NULL /*static, unused*/, __this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.WebCamTexture::INTERNAL_CALL_Stop(UnityEngine.WebCamTexture)
extern "C"  void WebCamTexture_INTERNAL_CALL_Stop_m3733059677 (Il2CppObject * __this /* static, unused */, WebCamTexture_t3635181805 * ___self0, const MethodInfo* method)
{
	typedef void (*WebCamTexture_INTERNAL_CALL_Stop_m3733059677_ftn) (WebCamTexture_t3635181805 *);
	static WebCamTexture_INTERNAL_CALL_Stop_m3733059677_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (WebCamTexture_INTERNAL_CALL_Stop_m3733059677_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.WebCamTexture::INTERNAL_CALL_Stop(UnityEngine.WebCamTexture)");
	_il2cpp_icall_func(___self0);
}
// System.Boolean UnityEngine.WebCamTexture::get_isPlaying()
extern "C"  bool WebCamTexture_get_isPlaying_m1109067512 (WebCamTexture_t3635181805 * __this, const MethodInfo* method)
{
	typedef bool (*WebCamTexture_get_isPlaying_m1109067512_ftn) (WebCamTexture_t3635181805 *);
	static WebCamTexture_get_isPlaying_m1109067512_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (WebCamTexture_get_isPlaying_m1109067512_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.WebCamTexture::get_isPlaying()");
	return _il2cpp_icall_func(__this);
}
// System.Void UnityEngine.WebCamTexture::set_deviceName(System.String)
extern "C"  void WebCamTexture_set_deviceName_m1209257657 (WebCamTexture_t3635181805 * __this, String_t* ___value0, const MethodInfo* method)
{
	typedef void (*WebCamTexture_set_deviceName_m1209257657_ftn) (WebCamTexture_t3635181805 *, String_t*);
	static WebCamTexture_set_deviceName_m1209257657_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (WebCamTexture_set_deviceName_m1209257657_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.WebCamTexture::set_deviceName(System.String)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Void UnityEngine.WebCamTexture::set_requestedFPS(System.Single)
extern "C"  void WebCamTexture_set_requestedFPS_m644257608 (WebCamTexture_t3635181805 * __this, float ___value0, const MethodInfo* method)
{
	typedef void (*WebCamTexture_set_requestedFPS_m644257608_ftn) (WebCamTexture_t3635181805 *, float);
	static WebCamTexture_set_requestedFPS_m644257608_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (WebCamTexture_set_requestedFPS_m644257608_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.WebCamTexture::set_requestedFPS(System.Single)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Void UnityEngine.WebCamTexture::set_requestedWidth(System.Int32)
extern "C"  void WebCamTexture_set_requestedWidth_m3687101425 (WebCamTexture_t3635181805 * __this, int32_t ___value0, const MethodInfo* method)
{
	typedef void (*WebCamTexture_set_requestedWidth_m3687101425_ftn) (WebCamTexture_t3635181805 *, int32_t);
	static WebCamTexture_set_requestedWidth_m3687101425_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (WebCamTexture_set_requestedWidth_m3687101425_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.WebCamTexture::set_requestedWidth(System.Int32)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Void UnityEngine.WebCamTexture::set_requestedHeight(System.Int32)
extern "C"  void WebCamTexture_set_requestedHeight_m3951846656 (WebCamTexture_t3635181805 * __this, int32_t ___value0, const MethodInfo* method)
{
	typedef void (*WebCamTexture_set_requestedHeight_m3951846656_ftn) (WebCamTexture_t3635181805 *, int32_t);
	static WebCamTexture_set_requestedHeight_m3951846656_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (WebCamTexture_set_requestedHeight_m3951846656_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.WebCamTexture::set_requestedHeight(System.Int32)");
	_il2cpp_icall_func(__this, ___value0);
}
// UnityEngine.WebCamDevice[] UnityEngine.WebCamTexture::get_devices()
extern "C"  WebCamDeviceU5BU5D_t699707851* WebCamTexture_get_devices_m3738445840 (Il2CppObject * __this /* static, unused */, const MethodInfo* method)
{
	typedef WebCamDeviceU5BU5D_t699707851* (*WebCamTexture_get_devices_m3738445840_ftn) ();
	static WebCamTexture_get_devices_m3738445840_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (WebCamTexture_get_devices_m3738445840_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.WebCamTexture::get_devices()");
	return _il2cpp_icall_func();
}
// System.Boolean UnityEngine.WebCamTexture::get_didUpdateThisFrame()
extern "C"  bool WebCamTexture_get_didUpdateThisFrame_m2572205429 (WebCamTexture_t3635181805 * __this, const MethodInfo* method)
{
	typedef bool (*WebCamTexture_get_didUpdateThisFrame_m2572205429_ftn) (WebCamTexture_t3635181805 *);
	static WebCamTexture_get_didUpdateThisFrame_m2572205429_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (WebCamTexture_get_didUpdateThisFrame_m2572205429_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.WebCamTexture::get_didUpdateThisFrame()");
	return _il2cpp_icall_func(__this);
}
// System.Void UnityEngine.WrapperlessIcall::.ctor()
extern "C"  void WrapperlessIcall__ctor_m1888400594 (WrapperlessIcall_t4003675496 * __this, const MethodInfo* method)
{
	{
		Attribute__ctor_m2985353781(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.WritableAttribute::.ctor()
extern "C"  void WritableAttribute__ctor_m2205809533 (WritableAttribute_t1716006665 * __this, const MethodInfo* method)
{
	{
		Attribute__ctor_m2985353781(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.YieldInstruction::.ctor()
extern "C"  void YieldInstruction__ctor_m539393484 (YieldInstruction_t3557331758 * __this, const MethodInfo* method)
{
	{
		Object__ctor_m1772956182(__this, /*hidden argument*/NULL);
		return;
	}
}
// Conversion methods for marshalling of: UnityEngine.YieldInstruction
extern "C" void YieldInstruction_t3557331758_marshal_pinvoke(const YieldInstruction_t3557331758& unmarshaled, YieldInstruction_t3557331758_marshaled_pinvoke& marshaled)
{
}
extern "C" void YieldInstruction_t3557331758_marshal_pinvoke_back(const YieldInstruction_t3557331758_marshaled_pinvoke& marshaled, YieldInstruction_t3557331758& unmarshaled)
{
}
// Conversion method for clean up from marshalling of: UnityEngine.YieldInstruction
extern "C" void YieldInstruction_t3557331758_marshal_pinvoke_cleanup(YieldInstruction_t3557331758_marshaled_pinvoke& marshaled)
{
}
// Conversion methods for marshalling of: UnityEngine.YieldInstruction
extern "C" void YieldInstruction_t3557331758_marshal_com(const YieldInstruction_t3557331758& unmarshaled, YieldInstruction_t3557331758_marshaled_com& marshaled)
{
}
extern "C" void YieldInstruction_t3557331758_marshal_com_back(const YieldInstruction_t3557331758_marshaled_com& marshaled, YieldInstruction_t3557331758& unmarshaled)
{
}
// Conversion method for clean up from marshalling of: UnityEngine.YieldInstruction
extern "C" void YieldInstruction_t3557331758_marshal_com_cleanup(YieldInstruction_t3557331758_marshaled_com& marshaled)
{
}
// System.Void UnityEngineInternal.GenericStack::.ctor()
extern "C"  void GenericStack__ctor_m2328546233 (GenericStack_t2344941421 * __this, const MethodInfo* method)
{
	{
		Stack__ctor_m1821673314(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngineInternal.MathfInternal::.cctor()
extern Il2CppClass* MathfInternal_t681132919_il2cpp_TypeInfo_var;
extern const uint32_t MathfInternal__cctor_m2600550988_MetadataUsageId;
extern "C"  void MathfInternal__cctor_m2600550988 (Il2CppObject * __this /* static, unused */, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (MathfInternal__cctor_m2600550988_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	{
		il2cpp_codegen_memory_barrier();
		((MathfInternal_t681132919_StaticFields*)MathfInternal_t681132919_il2cpp_TypeInfo_var->static_fields)->set_FloatMinNormal_0((1.17549435E-38f));
		il2cpp_codegen_memory_barrier();
		((MathfInternal_t681132919_StaticFields*)MathfInternal_t681132919_il2cpp_TypeInfo_var->static_fields)->set_FloatMinDenormal_1((1.401298E-45f));
		((MathfInternal_t681132919_StaticFields*)MathfInternal_t681132919_il2cpp_TypeInfo_var->static_fields)->set_IsFlushToZeroEnabled_2((bool)1);
		return;
	}
}
// Conversion methods for marshalling of: UnityEngineInternal.MathfInternal
extern "C" void MathfInternal_t681132919_marshal_pinvoke(const MathfInternal_t681132919& unmarshaled, MathfInternal_t681132919_marshaled_pinvoke& marshaled)
{
}
extern "C" void MathfInternal_t681132919_marshal_pinvoke_back(const MathfInternal_t681132919_marshaled_pinvoke& marshaled, MathfInternal_t681132919& unmarshaled)
{
}
// Conversion method for clean up from marshalling of: UnityEngineInternal.MathfInternal
extern "C" void MathfInternal_t681132919_marshal_pinvoke_cleanup(MathfInternal_t681132919_marshaled_pinvoke& marshaled)
{
}
// Conversion methods for marshalling of: UnityEngineInternal.MathfInternal
extern "C" void MathfInternal_t681132919_marshal_com(const MathfInternal_t681132919& unmarshaled, MathfInternal_t681132919_marshaled_com& marshaled)
{
}
extern "C" void MathfInternal_t681132919_marshal_com_back(const MathfInternal_t681132919_marshaled_com& marshaled, MathfInternal_t681132919& unmarshaled)
{
}
// Conversion method for clean up from marshalling of: UnityEngineInternal.MathfInternal
extern "C" void MathfInternal_t681132919_marshal_com_cleanup(MathfInternal_t681132919_marshaled_com& marshaled)
{
}
// System.Void UnityEngineInternal.TypeInferenceRuleAttribute::.ctor(UnityEngineInternal.TypeInferenceRules)
extern Il2CppClass* TypeInferenceRules_t435505844_il2cpp_TypeInfo_var;
extern const uint32_t TypeInferenceRuleAttribute__ctor_m1168575159_MetadataUsageId;
extern "C"  void TypeInferenceRuleAttribute__ctor_m1168575159 (TypeInferenceRuleAttribute_t471424957 * __this, int32_t ___rule0, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (TypeInferenceRuleAttribute__ctor_m1168575159_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	{
		int32_t L_0 = ___rule0;
		int32_t L_1 = L_0;
		Il2CppObject * L_2 = Box(TypeInferenceRules_t435505844_il2cpp_TypeInfo_var, &L_1);
		NullCheck((Enum_t2778772662 *)L_2);
		String_t* L_3 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Enum::ToString() */, (Enum_t2778772662 *)L_2);
		TypeInferenceRuleAttribute__ctor_m2173394041(__this, L_3, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngineInternal.TypeInferenceRuleAttribute::.ctor(System.String)
extern "C"  void TypeInferenceRuleAttribute__ctor_m2173394041 (TypeInferenceRuleAttribute_t471424957 * __this, String_t* ___rule0, const MethodInfo* method)
{
	{
		Attribute__ctor_m2985353781(__this, /*hidden argument*/NULL);
		String_t* L_0 = ___rule0;
		__this->set__rule_0(L_0);
		return;
	}
}
// System.String UnityEngineInternal.TypeInferenceRuleAttribute::ToString()
extern "C"  String_t* TypeInferenceRuleAttribute_ToString_m318752778 (TypeInferenceRuleAttribute_t471424957 * __this, const MethodInfo* method)
{
	{
		String_t* L_0 = __this->get__rule_0();
		return L_0;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
