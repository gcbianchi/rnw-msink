using ReactNative;
using ReactNative.Bridge;
using ReactNative.Modules.Core;
using ReactNative.Shell;
using ReactNative.UIManager;
using ReactNative.UIManager.Annotations;
using System.Collections.Generic;
using Windows.UI.Input.Inking;
using Windows.UI.Xaml.Controls;

namespace rnw
{
    class MainReactNativeHost : ReactNativeHost
    {
        public override string MainComponentName => "rnw";

#if !BUNDLE || DEBUG
        public override bool UseDeveloperSupport => true;
#else
        public override bool UseDeveloperSupport => false;
#endif

        protected override string JavaScriptMainModuleName => "index";

#if BUNDLE
        protected override string JavaScriptBundleFile => "ms-appx:///ReactAssets/index.windows.bundle";
#endif

        public class ReactInkToolbarManager : SimpleViewManager<InkToolbar>
        {
            public override string Name
            {
                get
                {
                    return "InkToolbarView";
                }

            }

            [ReactProp("width")]
            public void SetWidth(InkToolbar view, double width)
            {
                view.Width = width;
            }

            [ReactProp("height")]
            public void SetHeight(InkToolbar view, double height)
            {
                view.Height = height;
            }

            protected override InkToolbar CreateViewInstance(ThemedReactContext reactContext)
            {
                return new InkToolbar();
            }
        }
        public class ReactInkCanvasManager : SimpleViewManager<InkCanvas>
        {
            public override string Name
            {
                get
                {
                    return "InkCanvasView";
                }

            }

            [ReactProp("width")]
            public void SetWidth(InkCanvas view, double width)
            {
                view.Width = width;
            }

            [ReactProp("height")]
            public void SetHeight(InkCanvas view, double height)
            {
                view.Height = height;
            }

            protected override InkCanvas CreateViewInstance(ThemedReactContext reactContext)
            {
                InkCanvas inkCanvas = new InkCanvas();
                inkCanvas.InkPresenter.InputDeviceTypes =
                    Windows.UI.Core.CoreInputDeviceTypes.Mouse |
                    Windows.UI.Core.CoreInputDeviceTypes.Pen;
                return inkCanvas;
            }
        }

        public class ReactInkCanvasPackage : IReactPackage
        {
            public IReadOnlyList<INativeModule> CreateNativeModules(ReactContext reactContext)
            {
                return new List<INativeModule>(0);
            }

            public IReadOnlyList<IViewManager> CreateViewManagers(ReactContext reactContext)
            {
                return new List<IViewManager>
                {
                    new ReactInkCanvasManager(),
                    new ReactInkToolbarManager(),
                };
            }
        }

        protected override List<IReactPackage> Packages => new List<IReactPackage>
        {
            new MainReactPackage(),
            new ReactInkCanvasPackage(),
        };
    }
}

