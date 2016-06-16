﻿#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.Camera
struct Camera_t3533968274;
// Vuforia.VuforiaAbstractBehaviour
struct VuforiaAbstractBehaviour_t2427322319;
// UnityEngine.Mesh
struct Mesh_t1525280346;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"
#include "Vuforia_UnityExtensions_Vuforia_VuforiaRenderer_Vid267285774.h"
#include "UnityEngine_UnityEngine_Vector33525329789.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Vuforia.BackgroundPlaneAbstractBehaviour
struct  BackgroundPlaneAbstractBehaviour_t1953260483  : public MonoBehaviour_t3012272455
{
public:
	// Vuforia.VuforiaRenderer/VideoTextureInfo Vuforia.BackgroundPlaneAbstractBehaviour::mTextureInfo
	VideoTextureInfo_t267285774  ___mTextureInfo_2;
	// System.Int32 Vuforia.BackgroundPlaneAbstractBehaviour::mViewWidth
	int32_t ___mViewWidth_3;
	// System.Int32 Vuforia.BackgroundPlaneAbstractBehaviour::mViewHeight
	int32_t ___mViewHeight_4;
	// System.Boolean Vuforia.BackgroundPlaneAbstractBehaviour::mVideoBgConfigChanged
	bool ___mVideoBgConfigChanged_5;
	// UnityEngine.Camera Vuforia.BackgroundPlaneAbstractBehaviour::mCamera
	Camera_t3533968274 * ___mCamera_6;
	// Vuforia.VuforiaAbstractBehaviour Vuforia.BackgroundPlaneAbstractBehaviour::mQBehaviour
	VuforiaAbstractBehaviour_t2427322319 * ___mQBehaviour_7;
	// System.Int32 Vuforia.BackgroundPlaneAbstractBehaviour::defaultNumDivisions
	int32_t ___defaultNumDivisions_9;
	// UnityEngine.Mesh Vuforia.BackgroundPlaneAbstractBehaviour::mMesh
	Mesh_t1525280346 * ___mMesh_10;
	// System.Single Vuforia.BackgroundPlaneAbstractBehaviour::mStereoDepth
	float ___mStereoDepth_11;
	// UnityEngine.Vector3 Vuforia.BackgroundPlaneAbstractBehaviour::mBackgroundOffset
	Vector3_t3525329789  ___mBackgroundOffset_12;
	// Vuforia.VuforiaAbstractBehaviour Vuforia.BackgroundPlaneAbstractBehaviour::mVuforiaBehaviour
	VuforiaAbstractBehaviour_t2427322319 * ___mVuforiaBehaviour_13;
	// System.Int32 Vuforia.BackgroundPlaneAbstractBehaviour::mNumDivisions
	int32_t ___mNumDivisions_14;

public:
	inline static int32_t get_offset_of_mTextureInfo_2() { return static_cast<int32_t>(offsetof(BackgroundPlaneAbstractBehaviour_t1953260483, ___mTextureInfo_2)); }
	inline VideoTextureInfo_t267285774  get_mTextureInfo_2() const { return ___mTextureInfo_2; }
	inline VideoTextureInfo_t267285774 * get_address_of_mTextureInfo_2() { return &___mTextureInfo_2; }
	inline void set_mTextureInfo_2(VideoTextureInfo_t267285774  value)
	{
		___mTextureInfo_2 = value;
	}

	inline static int32_t get_offset_of_mViewWidth_3() { return static_cast<int32_t>(offsetof(BackgroundPlaneAbstractBehaviour_t1953260483, ___mViewWidth_3)); }
	inline int32_t get_mViewWidth_3() const { return ___mViewWidth_3; }
	inline int32_t* get_address_of_mViewWidth_3() { return &___mViewWidth_3; }
	inline void set_mViewWidth_3(int32_t value)
	{
		___mViewWidth_3 = value;
	}

	inline static int32_t get_offset_of_mViewHeight_4() { return static_cast<int32_t>(offsetof(BackgroundPlaneAbstractBehaviour_t1953260483, ___mViewHeight_4)); }
	inline int32_t get_mViewHeight_4() const { return ___mViewHeight_4; }
	inline int32_t* get_address_of_mViewHeight_4() { return &___mViewHeight_4; }
	inline void set_mViewHeight_4(int32_t value)
	{
		___mViewHeight_4 = value;
	}

	inline static int32_t get_offset_of_mVideoBgConfigChanged_5() { return static_cast<int32_t>(offsetof(BackgroundPlaneAbstractBehaviour_t1953260483, ___mVideoBgConfigChanged_5)); }
	inline bool get_mVideoBgConfigChanged_5() const { return ___mVideoBgConfigChanged_5; }
	inline bool* get_address_of_mVideoBgConfigChanged_5() { return &___mVideoBgConfigChanged_5; }
	inline void set_mVideoBgConfigChanged_5(bool value)
	{
		___mVideoBgConfigChanged_5 = value;
	}

	inline static int32_t get_offset_of_mCamera_6() { return static_cast<int32_t>(offsetof(BackgroundPlaneAbstractBehaviour_t1953260483, ___mCamera_6)); }
	inline Camera_t3533968274 * get_mCamera_6() const { return ___mCamera_6; }
	inline Camera_t3533968274 ** get_address_of_mCamera_6() { return &___mCamera_6; }
	inline void set_mCamera_6(Camera_t3533968274 * value)
	{
		___mCamera_6 = value;
		Il2CppCodeGenWriteBarrier(&___mCamera_6, value);
	}

	inline static int32_t get_offset_of_mQBehaviour_7() { return static_cast<int32_t>(offsetof(BackgroundPlaneAbstractBehaviour_t1953260483, ___mQBehaviour_7)); }
	inline VuforiaAbstractBehaviour_t2427322319 * get_mQBehaviour_7() const { return ___mQBehaviour_7; }
	inline VuforiaAbstractBehaviour_t2427322319 ** get_address_of_mQBehaviour_7() { return &___mQBehaviour_7; }
	inline void set_mQBehaviour_7(VuforiaAbstractBehaviour_t2427322319 * value)
	{
		___mQBehaviour_7 = value;
		Il2CppCodeGenWriteBarrier(&___mQBehaviour_7, value);
	}

	inline static int32_t get_offset_of_defaultNumDivisions_9() { return static_cast<int32_t>(offsetof(BackgroundPlaneAbstractBehaviour_t1953260483, ___defaultNumDivisions_9)); }
	inline int32_t get_defaultNumDivisions_9() const { return ___defaultNumDivisions_9; }
	inline int32_t* get_address_of_defaultNumDivisions_9() { return &___defaultNumDivisions_9; }
	inline void set_defaultNumDivisions_9(int32_t value)
	{
		___defaultNumDivisions_9 = value;
	}

	inline static int32_t get_offset_of_mMesh_10() { return static_cast<int32_t>(offsetof(BackgroundPlaneAbstractBehaviour_t1953260483, ___mMesh_10)); }
	inline Mesh_t1525280346 * get_mMesh_10() const { return ___mMesh_10; }
	inline Mesh_t1525280346 ** get_address_of_mMesh_10() { return &___mMesh_10; }
	inline void set_mMesh_10(Mesh_t1525280346 * value)
	{
		___mMesh_10 = value;
		Il2CppCodeGenWriteBarrier(&___mMesh_10, value);
	}

	inline static int32_t get_offset_of_mStereoDepth_11() { return static_cast<int32_t>(offsetof(BackgroundPlaneAbstractBehaviour_t1953260483, ___mStereoDepth_11)); }
	inline float get_mStereoDepth_11() const { return ___mStereoDepth_11; }
	inline float* get_address_of_mStereoDepth_11() { return &___mStereoDepth_11; }
	inline void set_mStereoDepth_11(float value)
	{
		___mStereoDepth_11 = value;
	}

	inline static int32_t get_offset_of_mBackgroundOffset_12() { return static_cast<int32_t>(offsetof(BackgroundPlaneAbstractBehaviour_t1953260483, ___mBackgroundOffset_12)); }
	inline Vector3_t3525329789  get_mBackgroundOffset_12() const { return ___mBackgroundOffset_12; }
	inline Vector3_t3525329789 * get_address_of_mBackgroundOffset_12() { return &___mBackgroundOffset_12; }
	inline void set_mBackgroundOffset_12(Vector3_t3525329789  value)
	{
		___mBackgroundOffset_12 = value;
	}

	inline static int32_t get_offset_of_mVuforiaBehaviour_13() { return static_cast<int32_t>(offsetof(BackgroundPlaneAbstractBehaviour_t1953260483, ___mVuforiaBehaviour_13)); }
	inline VuforiaAbstractBehaviour_t2427322319 * get_mVuforiaBehaviour_13() const { return ___mVuforiaBehaviour_13; }
	inline VuforiaAbstractBehaviour_t2427322319 ** get_address_of_mVuforiaBehaviour_13() { return &___mVuforiaBehaviour_13; }
	inline void set_mVuforiaBehaviour_13(VuforiaAbstractBehaviour_t2427322319 * value)
	{
		___mVuforiaBehaviour_13 = value;
		Il2CppCodeGenWriteBarrier(&___mVuforiaBehaviour_13, value);
	}

	inline static int32_t get_offset_of_mNumDivisions_14() { return static_cast<int32_t>(offsetof(BackgroundPlaneAbstractBehaviour_t1953260483, ___mNumDivisions_14)); }
	inline int32_t get_mNumDivisions_14() const { return ___mNumDivisions_14; }
	inline int32_t* get_address_of_mNumDivisions_14() { return &___mNumDivisions_14; }
	inline void set_mNumDivisions_14(int32_t value)
	{
		___mNumDivisions_14 = value;
	}
};

struct BackgroundPlaneAbstractBehaviour_t1953260483_StaticFields
{
public:
	// System.Single Vuforia.BackgroundPlaneAbstractBehaviour::maxDisplacement
	float ___maxDisplacement_8;

public:
	inline static int32_t get_offset_of_maxDisplacement_8() { return static_cast<int32_t>(offsetof(BackgroundPlaneAbstractBehaviour_t1953260483_StaticFields, ___maxDisplacement_8)); }
	inline float get_maxDisplacement_8() const { return ___maxDisplacement_8; }
	inline float* get_address_of_maxDisplacement_8() { return &___maxDisplacement_8; }
	inline void set_maxDisplacement_8(float value)
	{
		___maxDisplacement_8 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
