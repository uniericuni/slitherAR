#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.GameObject
struct GameObject_t4012695102;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"
#include "UnityEngine_UnityEngine_Vector33525329789.h"
#include "UnityEngine_UnityEngine_RaycastHit46221527.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// onPlane
struct  onPlane_t2955063229  : public MonoBehaviour_t3012272455
{
public:
	// UnityEngine.GameObject onPlane::cube
	GameObject_t4012695102 * ___cube_2;
	// UnityEngine.Vector3 onPlane::planeNorm
	Vector3_t3525329789  ___planeNorm_3;
	// UnityEngine.Vector3 onPlane::planeOrigin
	Vector3_t3525329789  ___planeOrigin_4;
	// UnityEngine.Vector3 onPlane::objPos
	Vector3_t3525329789  ___objPos_5;
	// System.Single onPlane::x
	float ___x_6;
	// System.Single onPlane::z
	float ___z_7;
	// System.Single onPlane::y
	float ___y_8;
	// UnityEngine.RaycastHit onPlane::hit
	RaycastHit_t46221527  ___hit_9;
	// System.Single onPlane::time
	float ___time_10;

public:
	inline static int32_t get_offset_of_cube_2() { return static_cast<int32_t>(offsetof(onPlane_t2955063229, ___cube_2)); }
	inline GameObject_t4012695102 * get_cube_2() const { return ___cube_2; }
	inline GameObject_t4012695102 ** get_address_of_cube_2() { return &___cube_2; }
	inline void set_cube_2(GameObject_t4012695102 * value)
	{
		___cube_2 = value;
		Il2CppCodeGenWriteBarrier(&___cube_2, value);
	}

	inline static int32_t get_offset_of_planeNorm_3() { return static_cast<int32_t>(offsetof(onPlane_t2955063229, ___planeNorm_3)); }
	inline Vector3_t3525329789  get_planeNorm_3() const { return ___planeNorm_3; }
	inline Vector3_t3525329789 * get_address_of_planeNorm_3() { return &___planeNorm_3; }
	inline void set_planeNorm_3(Vector3_t3525329789  value)
	{
		___planeNorm_3 = value;
	}

	inline static int32_t get_offset_of_planeOrigin_4() { return static_cast<int32_t>(offsetof(onPlane_t2955063229, ___planeOrigin_4)); }
	inline Vector3_t3525329789  get_planeOrigin_4() const { return ___planeOrigin_4; }
	inline Vector3_t3525329789 * get_address_of_planeOrigin_4() { return &___planeOrigin_4; }
	inline void set_planeOrigin_4(Vector3_t3525329789  value)
	{
		___planeOrigin_4 = value;
	}

	inline static int32_t get_offset_of_objPos_5() { return static_cast<int32_t>(offsetof(onPlane_t2955063229, ___objPos_5)); }
	inline Vector3_t3525329789  get_objPos_5() const { return ___objPos_5; }
	inline Vector3_t3525329789 * get_address_of_objPos_5() { return &___objPos_5; }
	inline void set_objPos_5(Vector3_t3525329789  value)
	{
		___objPos_5 = value;
	}

	inline static int32_t get_offset_of_x_6() { return static_cast<int32_t>(offsetof(onPlane_t2955063229, ___x_6)); }
	inline float get_x_6() const { return ___x_6; }
	inline float* get_address_of_x_6() { return &___x_6; }
	inline void set_x_6(float value)
	{
		___x_6 = value;
	}

	inline static int32_t get_offset_of_z_7() { return static_cast<int32_t>(offsetof(onPlane_t2955063229, ___z_7)); }
	inline float get_z_7() const { return ___z_7; }
	inline float* get_address_of_z_7() { return &___z_7; }
	inline void set_z_7(float value)
	{
		___z_7 = value;
	}

	inline static int32_t get_offset_of_y_8() { return static_cast<int32_t>(offsetof(onPlane_t2955063229, ___y_8)); }
	inline float get_y_8() const { return ___y_8; }
	inline float* get_address_of_y_8() { return &___y_8; }
	inline void set_y_8(float value)
	{
		___y_8 = value;
	}

	inline static int32_t get_offset_of_hit_9() { return static_cast<int32_t>(offsetof(onPlane_t2955063229, ___hit_9)); }
	inline RaycastHit_t46221527  get_hit_9() const { return ___hit_9; }
	inline RaycastHit_t46221527 * get_address_of_hit_9() { return &___hit_9; }
	inline void set_hit_9(RaycastHit_t46221527  value)
	{
		___hit_9 = value;
	}

	inline static int32_t get_offset_of_time_10() { return static_cast<int32_t>(offsetof(onPlane_t2955063229, ___time_10)); }
	inline float get_time_10() const { return ___time_10; }
	inline float* get_address_of_time_10() { return &___time_10; }
	inline void set_time_10(float value)
	{
		___time_10 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
