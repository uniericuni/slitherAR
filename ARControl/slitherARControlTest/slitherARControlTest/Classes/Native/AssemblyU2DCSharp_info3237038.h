#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// System.String
struct String_t;
// UnityEngine.GameObject
struct GameObject_t4012695102;
// UnityEngine.UI.Text
struct Text_t3286458198;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"
#include "UnityEngine_UnityEngine_Vector33525329789.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// info
struct  info_t3237038  : public MonoBehaviour_t3012272455
{
public:
	// System.String info::Info
	String_t* ___Info_2;
	// UnityEngine.GameObject info::imageTarget
	GameObject_t4012695102 * ___imageTarget_3;
	// UnityEngine.UI.Text info::posInfo
	Text_t3286458198 * ___posInfo_4;
	// UnityEngine.Vector3 info::pos1
	Vector3_t3525329789  ___pos1_5;
	// UnityEngine.Vector3 info::pos2
	Vector3_t3525329789  ___pos2_6;
	// UnityEngine.Vector3 info::pos3
	Vector3_t3525329789  ___pos3_7;
	// UnityEngine.Vector3 info::pos4
	Vector3_t3525329789  ___pos4_8;

public:
	inline static int32_t get_offset_of_Info_2() { return static_cast<int32_t>(offsetof(info_t3237038, ___Info_2)); }
	inline String_t* get_Info_2() const { return ___Info_2; }
	inline String_t** get_address_of_Info_2() { return &___Info_2; }
	inline void set_Info_2(String_t* value)
	{
		___Info_2 = value;
		Il2CppCodeGenWriteBarrier(&___Info_2, value);
	}

	inline static int32_t get_offset_of_imageTarget_3() { return static_cast<int32_t>(offsetof(info_t3237038, ___imageTarget_3)); }
	inline GameObject_t4012695102 * get_imageTarget_3() const { return ___imageTarget_3; }
	inline GameObject_t4012695102 ** get_address_of_imageTarget_3() { return &___imageTarget_3; }
	inline void set_imageTarget_3(GameObject_t4012695102 * value)
	{
		___imageTarget_3 = value;
		Il2CppCodeGenWriteBarrier(&___imageTarget_3, value);
	}

	inline static int32_t get_offset_of_posInfo_4() { return static_cast<int32_t>(offsetof(info_t3237038, ___posInfo_4)); }
	inline Text_t3286458198 * get_posInfo_4() const { return ___posInfo_4; }
	inline Text_t3286458198 ** get_address_of_posInfo_4() { return &___posInfo_4; }
	inline void set_posInfo_4(Text_t3286458198 * value)
	{
		___posInfo_4 = value;
		Il2CppCodeGenWriteBarrier(&___posInfo_4, value);
	}

	inline static int32_t get_offset_of_pos1_5() { return static_cast<int32_t>(offsetof(info_t3237038, ___pos1_5)); }
	inline Vector3_t3525329789  get_pos1_5() const { return ___pos1_5; }
	inline Vector3_t3525329789 * get_address_of_pos1_5() { return &___pos1_5; }
	inline void set_pos1_5(Vector3_t3525329789  value)
	{
		___pos1_5 = value;
	}

	inline static int32_t get_offset_of_pos2_6() { return static_cast<int32_t>(offsetof(info_t3237038, ___pos2_6)); }
	inline Vector3_t3525329789  get_pos2_6() const { return ___pos2_6; }
	inline Vector3_t3525329789 * get_address_of_pos2_6() { return &___pos2_6; }
	inline void set_pos2_6(Vector3_t3525329789  value)
	{
		___pos2_6 = value;
	}

	inline static int32_t get_offset_of_pos3_7() { return static_cast<int32_t>(offsetof(info_t3237038, ___pos3_7)); }
	inline Vector3_t3525329789  get_pos3_7() const { return ___pos3_7; }
	inline Vector3_t3525329789 * get_address_of_pos3_7() { return &___pos3_7; }
	inline void set_pos3_7(Vector3_t3525329789  value)
	{
		___pos3_7 = value;
	}

	inline static int32_t get_offset_of_pos4_8() { return static_cast<int32_t>(offsetof(info_t3237038, ___pos4_8)); }
	inline Vector3_t3525329789  get_pos4_8() const { return ___pos4_8; }
	inline Vector3_t3525329789 * get_address_of_pos4_8() { return &___pos4_8; }
	inline void set_pos4_8(Vector3_t3525329789  value)
	{
		___pos4_8 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
