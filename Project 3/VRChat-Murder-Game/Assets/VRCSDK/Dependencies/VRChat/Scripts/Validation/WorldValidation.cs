﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRCSDK2.Validation
{
    public static class WorldValidation
    {
        public static readonly string[] ComponentTypeWhiteList = new string[] {
            "VRCSDK2.VRCTriggerRelay",
            "VRCSDK2.VRC_AudioBank",
#if UNITY_STANDALONE
            "VRCSDK2.VRC_CustomRendererBehaviour",
#endif
            "VRCSDK2.VRC_DataStorage",
            "VRCSDK2.VRC_EventHandler",
            "VRCSDK2.VRC_IKFollower",
            "VRCSDK2.VRC_Label",
            "VRCSDK2.VRC_KeyEvents",
            "VRCSDK2.VRC_PhysicsRoot",
            "VRCSDK2.VRC_CombatSystem",
            "VRCSDK2.VRC_DestructibleStandard",
            "VRC_VisualDamage",
            "VRCSDK2.VRC_MirrorCamera",
#if UNITY_STANDALONE
            "VRCSDK2.VRC_MidiNoteIn",
#endif
            "VRCSDK2.VRC_OscButtonIn",
            "VRCSDK2.VRC_AddDamage",
            "VRCSDK2.VRC_AddHealth",
            "VRCSDK2.VRC_AvatarCalibrator",
            "VRCSDK2.VRC_AvatarPedestal",
            "VRCSDK2.VRC_GunStats",
            "VRCSDK2.VRC_JukeBox",
            "VRCSDK2.VRC_NPCSpawn",
            "VRCSDK2.VRC_ObjectSpawn",
            "VRCSDK2.VRC_ObjectSync",
            "VRCSDK2.VRC_Pickup",
            "VRCSDK2.VRC_PortalMarker",
            "VRCSDK2.VRC_SlideShow",
            "VRCSDK2.VRC_SpatialAudioSource",
            "VRCSDK2.VRC_StationInput",
            "VRCSDK2.VRC_SyncAnimation",
            "VRCSDK2.VRC_SyncVideoPlayer",
            "VRCSDK2.VRC_SyncVideoStream",
            "VRCSDK2.VRC_VideoScreen",
            "VRCSDK2.VRC_VideoSpeaker",
            "VRCSDK2.VRC_PlayerAudioOverride",
            "VRC_YouTubeSync", // TODO: this is deprecated and should be removed
            "VRCSDK2.VRC_MirrorReflection",
#if UNITY_STANDALONE
            "VRCSDK2.scripts.Scenes.VRC_Panorama",
#endif
            "VRCSDK2.VRC_PlayerMods",
            "VRCSDK2.VRC_SceneDescriptor",
            "VRCSDK2.VRC_SceneResetPosition",
            "VRCSDK2.VRC_SceneSmoothShift",
            "VRCSDK2.VRC_SpecialLayer",
            "VRCSDK2.VRC_Station",
            "VRCSDK2.VRC_StereoObject",
            "VRCSDK2.VRC_TimedEvents",
            "VRCSDK2.VRC_Trigger",
            "VRCSDK2.VRC_TriggerColliderEventTrigger",
            "VRCSDK2.VRC_UseEvents",
#if UNITY_STANDALONE
            "VRCSDK2.VRC_Water",
            "VRCSDK2.VRC_Webpanel", // TODO: this is deprecated and should be removed
#endif
            "VRCSDK2.VRC_UiShape",
            "VRC.Core.PipelineManager",
            "UiInputField",
            "VRCProjectSettings",
            "DynamicBone",
            "DynamicBoneCollider",
            "TMPro.InlineGraphic",
            "TMPro.InlineGraphicManager",
            "TMPro.TMP_Dropdown",
            "TMPro.TMP_InputField",
            "TMPro.TMP_ScrollbarEventHandler",
            "TMPro.TMP_SelectionCaret",
            "TMPro.TMP_SpriteAnimator",
            "TMPro.TMP_SubMesh",
            "TMPro.TMP_SubMeshUI",
            "TMPro.TMP_Text",
            "TMPro.TextMeshPro",
            "TMPro.TextMeshProUGUI",
            "TMPro.TextContainer",
            "TMPro.TMP_Dropdown+DropdownItem",
            "UnityEngine.EventSystems.EventSystem",
            "UnityEngine.EventSystems.EventTrigger",
            "UnityEngine.EventSystems.UIBehaviour",
            "UnityEngine.EventSystems.BaseInput",
            "UnityEngine.EventSystems.BaseInputModule",
            "UnityEngine.EventSystems.PointerInputModule",
            "UnityEngine.EventSystems.StandaloneInputModule",
            "UnityEngine.EventSystems.TouchInputModule",
            "UnityEngine.EventSystems.BaseRaycaster",
            "UnityEngine.EventSystems.PhysicsRaycaster",
            "UnityEngine.UI.Button",
            "UnityEngine.UI.Dropdown",
            "UnityEngine.UI.Dropdown+DropdownItem",
            "UnityEngine.UI.Graphic",
            "UnityEngine.UI.GraphicRaycaster",
            "UnityEngine.UI.Image",
            "UnityEngine.UI.InputField",
            "UnityEngine.UI.Mask",
            "UnityEngine.UI.MaskableGraphic",
            "UnityEngine.UI.RawImage",
            "UnityEngine.UI.RectMask2D",
            "UnityEngine.UI.Scrollbar",
            "UnityEngine.UI.ScrollRect",
            "UnityEngine.UI.Selectable",
            "UnityEngine.UI.Slider",
            "UnityEngine.UI.Text",
            "UnityEngine.UI.Toggle",
            "UnityEngine.UI.ToggleGroup",
            "UnityEngine.UI.AspectRatioFitter",
            "UnityEngine.UI.CanvasScaler",
            "UnityEngine.UI.ContentSizeFitter",
            "UnityEngine.UI.GridLayoutGroup",
            "UnityEngine.UI.HorizontalLayoutGroup",
            "UnityEngine.UI.HorizontalOrVerticalLayoutGroup",
            "UnityEngine.UI.LayoutElement",
            "UnityEngine.UI.LayoutGroup",
            "UnityEngine.UI.VerticalLayoutGroup",
            "UnityEngine.UI.BaseMeshEffect",
            "UnityEngine.UI.Outline",
            "UnityEngine.UI.PositionAsUV1",
            "UnityEngine.UI.Shadow",
#if UNITY_STANDALONE
            "UnityEngine.Rendering.PostProcessing.PostProcessDebug",
            "UnityEngine.Rendering.PostProcessing.PostProcessLayer",
            "UnityEngine.Rendering.PostProcessing.PostProcessVolume",
            "UnityEngine.PostProcessing.PostProcessingBehaviour",
            "VolumetricFogAndMist.FogVolumeExtensions",
            "DynamicFogAndMist.FogVolumeExtensions",
#endif
            "RenderHeads.Media.AVProVideo.ApplyToMaterial",
            "RenderHeads.Media.AVProVideo.ApplyToMesh",
            "RenderHeads.Media.AVProVideo.AudioOutput",
            "RenderHeads.Media.AVProVideo.CubemapCube",
            "RenderHeads.Media.AVProVideo.DebugOverlay",
            "RenderHeads.Media.AVProVideo.DisplayBackground",
            "RenderHeads.Media.AVProVideo.DisplayIMGUI",
            "RenderHeads.Media.AVProVideo.DisplayUGUI",
            "RenderHeads.Media.AVProVideo.MediaPlayer",
            "RenderHeads.Media.AVProVideo.StreamParser",
            "RenderHeads.Media.AVProVideo.SubtitlesUGUI",
            "RenderHeads.Media.AVProVideo.UpdateStereoMaterial",
            "PhysSound.PhysSoundBase",
            "PhysSound.PhysSoundObject",
            "PhysSound.PhysSoundTempAudio",
            "PhysSound.PhysSoundTempAudioPool",
            "PhysSound.PhysSoundTerrain",
            "RealisticEyeMovements.EyeAndHeadAnimator",
            "RealisticEyeMovements.LookTargetController",
#if UNITY_STANDALONE
            "DynamicFogAndMist.DynamicFog",
            "DynamicFogAndMist.DynamicFogManager",
            "DynamicFogAndMist.DynamicFogOfWar",
            "DynamicFogAndMist.FogVolume",
            "VolumetricFogAndMist.FogAreaCullingManager",
            "VolumetricFogAndMist.FogVolume",
            "VolumetricFogAndMist.VolumetricFog",
            "VolumetricFogAndMist.VolumetricFogPosT",
            "VolumetricFogAndMist.VolumetricFogPreT",
#endif
            "OVRLipSync",
            "OVRLipSyncContext",
            "OVRLipSyncContextBase",
            "OVRLipSyncContextCanned",
            "OVRLipSyncContextMorphTarget",
            "OVRLipSyncContextTextureFlip",
            "ONSPReflectionZone",
            "OculusSpatializerUnity",
            "ONSPAmbisonicsNative",
            "ONSPAudioSource",
            "RootMotion.FinalIK.BipedIK",
            "RootMotion.FinalIK.FingerRig",
            "RootMotion.FinalIK.Grounder",
            "RootMotion.FinalIK.GrounderBipedIK",
            "RootMotion.FinalIK.GrounderFBBIK",
            "RootMotion.FinalIK.GrounderIK",
            "RootMotion.FinalIK.GrounderQuadruped",
            "RootMotion.FinalIK.GrounderVRIK",
            "RootMotion.FinalIK.AimIK",
            "RootMotion.FinalIK.CCDIK",
            "RootMotion.FinalIK.FABRIK",
            "RootMotion.FinalIK.FABRIKRoot",
            "RootMotion.FinalIK.FullBodyBipedIK",
            "RootMotion.FinalIK.IK",
            "RootMotion.FinalIK.IKExecutionOrder",
            "RootMotion.FinalIK.LegIK",
            "RootMotion.FinalIK.LimbIK",
            "RootMotion.FinalIK.LookAtIK",
            "RootMotion.FinalIK.TrigonometricIK",
            "RootMotion.FinalIK.VRIK",
            "RootMotion.FinalIK.FBBIKArmBending",
            "RootMotion.FinalIK.FBBIKHeadEffector",
            "RootMotion.FinalIK.TwistRelaxer",
            "RootMotion.FinalIK.InteractionObject",
            "RootMotion.FinalIK.InteractionSystem",
            "RootMotion.FinalIK.InteractionTarget",
            "RootMotion.FinalIK.InteractionTrigger",
            "RootMotion.FinalIK.GenericPoser",
            "RootMotion.FinalIK.HandPoser",
            "RootMotion.FinalIK.Poser",
            "RootMotion.FinalIK.RagdollUtility",
            "RootMotion.FinalIK.RotationLimit",
            "RootMotion.FinalIK.RotationLimitAngle",
            "RootMotion.FinalIK.RotationLimitHinge",
            "RootMotion.FinalIK.RotationLimitPolygonal",
            "RootMotion.FinalIK.RotationLimitSpline",
            "RootMotion.FinalIK.AimPoser",
            "RootMotion.FinalIK.Amplifier",
            "RootMotion.FinalIK.BodyTilt",
            "RootMotion.FinalIK.HitReaction",
            "RootMotion.FinalIK.HitReactionVRIK",
            "RootMotion.FinalIK.Inertia",
            "RootMotion.FinalIK.OffsetModifier",
            "RootMotion.FinalIK.OffsetModifierVRIK",
            "RootMotion.FinalIK.OffsetPose",
            "RootMotion.FinalIK.Recoil",
            "RootMotion.FinalIK.ShoulderRotator",
            "RootMotion.Dynamics.AnimationBlocker",
            "RootMotion.Dynamics.BehaviourAnimatedStagger",
            "RootMotion.Dynamics.BehaviourBase",
            "RootMotion.Dynamics.BehaviourFall",
            "RootMotion.Dynamics.BehaviourPuppet",
            "RootMotion.Dynamics.JointBreakBroadcaster",
            "RootMotion.Dynamics.MuscleCollisionBroadcaster",
            "RootMotion.Dynamics.PressureSensor",
            "RootMotion.Dynamics.Prop",
            "RootMotion.Dynamics.PropRoot",
            "RootMotion.Dynamics.PuppetMaster",
            "RootMotion.Dynamics.PuppetMasterSettings",
            // TODO: remove these if they are only needed in editor
            "RootMotion.Dynamics.BipedRagdollCreator",
            "RootMotion.Dynamics.RagdollCreator",
            "RootMotion.Dynamics.RagdollEditor",
            //
            "RootMotion.SolverManager",
            "RootMotion.TriggerEventBroadcaster",
            "UnityStandardAssets.Cameras.AbstractTargetFollower",
            "UnityStandardAssets.Cameras.AutoCam",
            "UnityStandardAssets.Cameras.FreeLookCam",
            "UnityStandardAssets.Cameras.HandHeldCam",
            "UnityStandardAssets.Cameras.LookatTarget",
            "UnityStandardAssets.Cameras.PivotBasedCameraRig",
            "UnityStandardAssets.Cameras.ProtectCameraFromWallClip",
            "UnityStandardAssets.Cameras.TargetFieldOfView",
            "UnityStandardAssets.Characters.FirstPerson.FirstPersonController",
            "UnityStandardAssets.Characters.FirstPerson.HeadBob",
            "UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController",
            "UnityStandardAssets.Vehicles.Ball.Ball",
            "UnityStandardAssets.Vehicles.Ball.BallUserControl",
            "UnityStandardAssets.Characters.ThirdPerson.AICharacterControl",
            "UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter",
            "UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl",
            "UnityStandardAssets.CrossPlatformInput.AxisTouchButton",
            "UnityStandardAssets.CrossPlatformInput.ButtonHandler",
            "UnityStandardAssets.CrossPlatformInput.InputAxisScrollbar",
            "UnityStandardAssets.CrossPlatformInput.Joystick",
            "UnityStandardAssets.CrossPlatformInput.MobileControlRig",
            "UnityStandardAssets.CrossPlatformInput.TiltInput",
            "UnityStandardAssets.CrossPlatformInput.TouchPad",
#if UNITY_STANDALONE
            "UnityStandardAssets.Water.WaterBasic",
            "UnityStandardAssets.Water.Displace",
            "UnityStandardAssets.Water.GerstnerDisplace",
            "UnityStandardAssets.Water.PlanarReflection",
            "UnityStandardAssets.Water.SpecularLighting",
            "UnityStandardAssets.Water.Water",
            "UnityStandardAssets.Water.WaterBase",
            "UnityStandardAssets.Water.WaterTile",
#endif
            "UnityStandardAssets.Effects.AfterburnerPhysicsForce",
            "UnityStandardAssets.Effects.ExplosionFireAndDebris",
            "UnityStandardAssets.Effects.ExplosionPhysicsForce",
            "UnityStandardAssets.Effects.Explosive",
            "UnityStandardAssets.Effects.ExtinguishableParticleSystem",
            "UnityStandardAssets.Effects.FireLight",
            "UnityStandardAssets.Effects.Hose",
            "UnityStandardAssets.Effects.ParticleSystemMultiplier",
            "UnityStandardAssets.Effects.SmokeParticles",
            "UnityStandardAssets.Effects.WaterHoseParticles",
            "UnityStandardAssets.Utility.ActivateTrigger",
            "AlphaButtonClickMask",
            "UnityStandardAssets.Utility.AutoMoveAndRotate",
            "UnityStandardAssets.Utility.DragRigidbody",
            "UnityStandardAssets.Utility.DynamicShadowSettings",
            "EventSystemChecker",
            "UnityStandardAssets.Utility.FollowTarget",
            "UnityStandardAssets.Utility.FPSCounter",
            "UnityStandardAssets.Utility.ObjectResetter",
            "UnityStandardAssets.Utility.ParticleSystemDestroyer",
            "UnityStandardAssets.Utility.SimpleActivatorMenu",
            "UnityStandardAssets.Utility.SimpleMouseRotator",
            "UnityStandardAssets.Utility.SmoothFollow",
            "UnityStandardAssets.Utility.TimedObjectActivator",
            "UnityStandardAssets.Utility.TimedObjectDestructor",
            "UnityStandardAssets.Utility.WaypointCircuit",
            "UnityStandardAssets.Utility.WaypointProgressTracker",
            "UnityStandardAssets.Vehicles.Aeroplane.AeroplaneAiControl",
            "UnityStandardAssets.Vehicles.Aeroplane.AeroplaneAudio",
            "UnityStandardAssets.Vehicles.Aeroplane.AeroplaneController",
            "UnityStandardAssets.Vehicles.Aeroplane.AeroplaneControlSurfaceAnimator",
            "UnityStandardAssets.Vehicles.Aeroplane.AeroplanePropellerAnimator",
            "UnityStandardAssets.Vehicles.Aeroplane.AeroplaneUserControl2Axis",
            "UnityStandardAssets.Vehicles.Aeroplane.AeroplaneUserControl4Axis",
            "UnityStandardAssets.Vehicles.Aeroplane.JetParticleEffect",
            "UnityStandardAssets.Vehicles.Aeroplane.LandingGear",
            "UnityStandardAssets.Vehicles.Car.BrakeLight",
            "UnityStandardAssets.Vehicles.Car.CarAIControl",
            "UnityStandardAssets.Vehicles.Car.CarAudio",
            "UnityStandardAssets.Vehicles.Car.CarController",
            "UnityStandardAssets.Vehicles.Car.CarSelfRighting",
            "UnityStandardAssets.Vehicles.Car.CarUserControl",
            "UnityStandardAssets.Vehicles.Car.Mudguard",
            "UnityStandardAssets.Vehicles.Car.SkidTrail",
            "UnityStandardAssets.Vehicles.Car.Suspension",
            "UnityStandardAssets.Vehicles.Car.WheelEffects",
            "UnityEngine.WindZone",
            "UnityEngine.Video.VideoPlayer",
            "UnityEngine.Tilemaps.Tilemap",
            "UnityEngine.Tilemaps.TilemapRenderer",
            "UnityEngine.Terrain",
            "UnityEngine.Tree",
            "UnityEngine.SpriteMask",
            "UnityEngine.ParticleEmitter",
            "UnityEngine.EllipsoidParticleEmitter",
            "UnityEngine.MeshParticleEmitter",
            "UnityEngine.ParticleAnimator",
            "UnityEngine.ParticleRenderer",
            "UnityEngine.WorldParticleCollider",
            "UnityEngine.Grid",
            "UnityEngine.GridLayout",
            "UnityEngine.AudioSource",
            "UnityEngine.AudioReverbZone",
            "UnityEngine.AudioLowPassFilter",
            "UnityEngine.AudioHighPassFilter",
            "UnityEngine.AudioDistortionFilter",
            "UnityEngine.AudioEchoFilter",
            "UnityEngine.AudioChorusFilter",
            "UnityEngine.AudioReverbFilter",
            "UnityEngine.Playables.PlayableDirector",
            "UnityEngine.TerrainCollider",
            "UnityEngine.Canvas",
            "UnityEngine.CanvasGroup",
            "UnityEngine.CanvasRenderer",
            "UnityEngine.GUIText",
            "UnityEngine.TextMesh",
            "UnityEngine.Animation",
            "UnityEngine.Animator",
            "UnityEngine.AI.NavMeshAgent",
            "UnityEngine.AI.NavMeshObstacle",
            "UnityEngine.AI.OffMeshLink",
            "UnityEngine.Cloth",
            "UnityEngine.WheelCollider",
            "UnityEngine.Rigidbody",
            "UnityEngine.Joint",
            "UnityEngine.HingeJoint",
            "UnityEngine.SpringJoint",
            "UnityEngine.FixedJoint",
            "UnityEngine.CharacterJoint",
            "UnityEngine.ConfigurableJoint",
            "UnityEngine.ConstantForce",
            "UnityEngine.Collider",
            "UnityEngine.BoxCollider",
            "UnityEngine.SphereCollider",
            "UnityEngine.MeshCollider",
            "UnityEngine.CapsuleCollider",
            "UnityEngine.CharacterController",
            "UnityEngine.ParticleSystem",
            "UnityEngine.ParticleSystemRenderer",
            "UnityEngine.BillboardRenderer",
            "UnityEngine.Camera",
            "UnityEngine.FlareLayer",
            "UnityEngine.SkinnedMeshRenderer",
            "UnityEngine.Renderer",
            "UnityEngine.TrailRenderer",
            "UnityEngine.LineRenderer",
            "UnityEngine.GUIElement",
            "UnityEngine.GUITexture",
            "UnityEngine.GUILayer",
            "UnityEngine.Light",
            "UnityEngine.LightProbeGroup",
            "UnityEngine.LightProbeProxyVolume",
            "UnityEngine.LODGroup",
            "UnityEngine.ReflectionProbe",
            "UnityEngine.SpriteRenderer",
            "UnityEngine.Transform",
            "UnityEngine.RectTransform",
            "UnityEngine.Rendering.SortingGroup",
            "UnityEngine.Projector",
            "UnityEngine.OcclusionPortal",
            "UnityEngine.OcclusionArea",
            "UnityEngine.LensFlare",
            "UnityEngine.Skybox",
            "UnityEngine.MeshFilter",
            "UnityEngine.Halo",
            "UnityEngine.MeshRenderer",
            "VRC.Udon.UdonBehaviour",
            "VirtualMarketplaceItem"
        };

        public static readonly string[] ShaderWhiteList = new string[]
        {
            "VRChat/Mobile/Standard Lite",
            "VRChat/Mobile/Diffuse",
            "VRChat/Mobile/Bumped Diffuse",
            "VRChat/Mobile/Bumped Mapped Specular",
            "VRChat/Mobile/Toon Lit",
            "VRChat/Mobile/MatCap Lit",
            "VRChat/Mobile/Lightmapped",
            "VRChat/Mobile/Skybox",
            "VRChat/Mobile/Particles/Additive",
            "VRChat/Mobile/Particles/Multiply",
            "FX/MirrorReflection",
            "UI/Default",
        };

        private static List<int> scannedObjects = new List<int>();


        public static IEnumerator RemoveIllegalComponentsEnumerator(GameObject target, bool retry = true)
        {
            return ValidationUtils.RemoveIllegalComponentsEnumerator(target, ValidationUtils.WhitelistedTypes("world", ComponentTypeWhiteList), retry, true);
        }

        public static IEnumerator RemoveIllegalComponentsEnumerator(GameObject[] targets, bool retry = true)
        {
            foreach(GameObject target in targets)
                yield return ValidationUtils.RemoveIllegalComponentsEnumerator(target, ValidationUtils.WhitelistedTypes("world", ComponentTypeWhiteList), retry, true);
        }

        public static IEnumerable<Component> FindIllegalComponents(GameObject target)
        {
            return ValidationUtils.FindIllegalComponents(target, ValidationUtils.WhitelistedTypes("world", ComponentTypeWhiteList));
        }

        public static void ScanGameobject(GameObject target)
        {
            if(scannedObjects.Contains(target.GetInstanceID()))
                return;

            ValidationUtils.RemoveIllegalComponents(target, ValidationUtils.WhitelistedTypes("world", ComponentTypeWhiteList));

            scannedObjects.Add(target.GetInstanceID());
        }

        public static void ClearScannedGameobjectCache()
        {
            scannedObjects.Clear();
        }

        public static IEnumerable<Shader> FindIllegalShaders(GameObject target)
        {
            return ShaderValidation.FindIllegalShaders(target, ShaderWhiteList);
        }
    }
}
