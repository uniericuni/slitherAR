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
	// UnityEngine.GameObject info::sphere
	GameObject_t4012695102 * ___sphere_3;
	// UnityEngine.UI.Text info::posInfo
	Text_t3286458198 * ___posInfo_4;

public:
	inline static int32_t get_offset_of_Info_2() { return static_cast<int32_t>(offsetof(info_t3237038, ___Info_2)); }
	inline String_t* get_Info_2() const { return ___Info_2; }
	inline String_t** get_address_of_Info_2() { return &___Info_2; }
	inline void set_Info_2(String_t* value)
	{
		___Info_2 = value;
		Il2CppCodeGenWriteBarrier(&___Info_2, value);
	}

	inline static int32_t get_offset_of_sphere_3() { return static_cast<int32_t>(offsetof(info_t3237038, ___sphere_3)); }
	inline GameObject_t4012695102 * get_sphere_3() const { return ___sphere_3; }
	inline GameObject_t4012695102 ** get_address_of_sphere_3() { return &___sphere_3; }
	inline void set_sphere_3(GameObject_t4012695102 * value)
	{
		___sphere_3 = value;
		Il2CppCodeGenWriteBarrier(&___sphere_3, value);
	}

	inline static int32_t get_offset_of_posInfo_4() { return static_cast<int32_t>(offsetof(info_t3237038, ___posInfo_4)); }
	inline Text_t3286458198 * get_posInfo_4() const { return ___posInfo_4; }
	inline Text_t3286458198 ** get_address_of_posInfo_4() { return &___posInfo_4; }
	inline void set_posInfo_4(Text_t3286458198 * value)
	{
		___posInfo_4 = value;
		Il2CppCodeGenWriteBarrier(&___posInfo_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
