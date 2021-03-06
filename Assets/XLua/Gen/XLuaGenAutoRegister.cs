﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using System;
using System.Collections.Generic;
using System.Reflection;


namespace CSObjectWrap
{
    public class XLua_Gen_Initer_Register__
	{
	    static XLua_Gen_Initer_Register__()
        {
		    XLua.LuaEnv.AddIniter((luaenv, translator) => {
			    
				translator.DelayWrapLoader(typeof(UnityEngine.Input), UnityEngineInputWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AudioSource), UnityEngineAudioSourceWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AudioClip), UnityEngineAudioClipWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Application), UnityEngineApplicationWrap.__Register);
				
				translator.DelayWrapLoader(typeof(CatLib.Base.CApp), CatLibBaseCAppWrap.__Register);
				
				translator.DelayWrapLoader(typeof(CatLib.Base.CComponent), CatLibBaseCComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(CatLib.Base.CMonoComponent), CatLibBaseCMonoComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(CatLib.Base.CLuaMonoComponent), CatLibBaseCLuaMonoComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(CatLib.Base.FAutoUpdate), CatLibBaseFAutoUpdateWrap.__Register);
				
				translator.DelayWrapLoader(typeof(CatLib.Base.FDispatcher), CatLibBaseFDispatcherWrap.__Register);
				
				translator.DelayWrapLoader(typeof(CatLib.Base.FLua), CatLibBaseFLuaWrap.__Register);
				
				translator.DelayWrapLoader(typeof(CatLib.Base.FNetwork), CatLibBaseFNetworkWrap.__Register);
				
				translator.DelayWrapLoader(typeof(CatLib.Base.FResources), CatLibBaseFResourcesWrap.__Register);
				
				translator.DelayWrapLoader(typeof(CatLib.Contracts.Base.IApplication), CatLibContractsBaseIApplicationWrap.__Register);
				
				translator.DelayWrapLoader(typeof(CatLib.Contracts.Container.IBindData), CatLibContractsContainerIBindDataWrap.__Register);
				
				translator.DelayWrapLoader(typeof(CatLib.Contracts.Container.IContainer), CatLibContractsContainerIContainerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(CatLib.Contracts.Container.ITmpData), CatLibContractsContainerITmpDataWrap.__Register);
				
				translator.DelayWrapLoader(typeof(CatLib.Contracts.Event.IDispatcher), CatLibContractsEventIDispatcherWrap.__Register);
				
				translator.DelayWrapLoader(typeof(CatLib.Contracts.Event.IEvent), CatLibContractsEventIEventWrap.__Register);
				
				translator.DelayWrapLoader(typeof(CatLib.Contracts.Lua.ILua), CatLibContractsLuaILuaWrap.__Register);
				
				translator.DelayWrapLoader(typeof(CatLib.Contracts.Network.IConnector), CatLibContractsNetworkIConnectorWrap.__Register);
				
				translator.DelayWrapLoader(typeof(CatLib.Contracts.Network.IConnectorHttp), CatLibContractsNetworkIConnectorHttpWrap.__Register);
				
				translator.DelayWrapLoader(typeof(CatLib.Contracts.Network.IConnectorSocket), CatLibContractsNetworkIConnectorSocketWrap.__Register);
				
				translator.DelayWrapLoader(typeof(CatLib.Contracts.Network.INetwork), CatLibContractsNetworkINetworkWrap.__Register);
				
				translator.DelayWrapLoader(typeof(CatLib.Contracts.ResourcesSystem.IResources), CatLibContractsResourcesSystemIResourcesWrap.__Register);
				
				translator.DelayWrapLoader(typeof(CatLib.Contracts.UpdateSystem.IAutoUpdate), CatLibContractsUpdateSystemIAutoUpdateWrap.__Register);
				
				translator.DelayWrapLoader(typeof(CatLib.Support.CEnv), CatLibSupportCEnvWrap.__Register);
				
				translator.DelayWrapLoader(typeof(CapLib.Base.CApplication), CapLibBaseCApplicationWrap.__Register);
				
				translator.DelayWrapLoader(typeof(LuaBehaviour), LuaBehaviourWrap.__Register);
				
				translator.DelayWrapLoader(typeof(XLuaTest.Pedding), XLuaTestPeddingWrap.__Register);
				
				translator.DelayWrapLoader(typeof(XLuaTest.MyStruct), XLuaTestMyStructWrap.__Register);
				
				translator.DelayWrapLoader(typeof(XLuaTest.MyEnum), XLuaTestMyEnumWrap.__Register);
				
				translator.DelayWrapLoader(typeof(XLuaTest.NoGc), XLuaTestNoGcWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Coroutine_Runner), Coroutine_RunnerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.WaitForSeconds), UnityEngineWaitForSecondsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.WWW), UnityEngineWWWWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Foo1Parent), Foo1ParentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Foo2Parent), Foo2ParentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Foo1Child), Foo1ChildWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Foo2Child), Foo2ChildWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Foo), FooWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FooExtension), FooExtensionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(object), SystemObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Object), UnityEngineObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Vector2), UnityEngineVector2Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Vector3), UnityEngineVector3Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Vector4), UnityEngineVector4Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Quaternion), UnityEngineQuaternionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Color), UnityEngineColorWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Ray), UnityEngineRayWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Bounds), UnityEngineBoundsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Ray2D), UnityEngineRay2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Time), UnityEngineTimeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GameObject), UnityEngineGameObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Component), UnityEngineComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Behaviour), UnityEngineBehaviourWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Transform), UnityEngineTransformWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Resources), UnityEngineResourcesWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.TextAsset), UnityEngineTextAssetWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Keyframe), UnityEngineKeyframeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AnimationCurve), UnityEngineAnimationCurveWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AnimationClip), UnityEngineAnimationClipWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.MonoBehaviour), UnityEngineMonoBehaviourWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem), UnityEngineParticleSystemWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SkinnedMeshRenderer), UnityEngineSkinnedMeshRendererWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Renderer), UnityEngineRendererWrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.Collections.Generic.List<int>), SystemCollectionsGenericList_1SystemInt32Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Debug), UnityEngineDebugWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Tutorial.BaseClass), TutorialBaseClassWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Tutorial.TestEnum), TutorialTestEnumWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Tutorial.DrivenClass), TutorialDrivenClassWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Tutorial.DrivenClass.TestEnumInner), TutorialDrivenClassTestEnumInnerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Tutorial.Calc), TutorialCalcWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Tutorial.DrivenClassExtensions), TutorialDrivenClassExtensionsWrap.__Register);
				
				
				translator.AddInterfaceBridgeCreator(typeof(InvokeLua.ICalc), InvokeLuaICalcBridge.__Create);
				
				translator.AddInterfaceBridgeCreator(typeof(XLuaTest.IExchanger), XLuaTestIExchangerBridge.__Create);
				
				translator.AddInterfaceBridgeCreator(typeof(System.Collections.IEnumerator), SystemCollectionsIEnumeratorBridge.__Create);
				
				translator.AddInterfaceBridgeCreator(typeof(CSCallLua.ItfD), CSCallLuaItfDBridge.__Create);
				
			});
		}
		
		
	}
	
}
namespace XLua
{
	public partial class ObjectTranslator
	{
		static CSObjectWrap.XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj = new CSObjectWrap.XLua_Gen_Initer_Register__();
		static CSObjectWrap.XLua_Gen_Initer_Register__ gen_reg_dumb_obj {get{return s_gen_reg_dumb_obj;}}
	}
	
	public static partial class Utils
    {
	    
	    static Utils()
		{
		    extension_method_map = new Dictionary<Type, IEnumerable<MethodInfo>>()
			{
			    
			};
		}
	}
}
