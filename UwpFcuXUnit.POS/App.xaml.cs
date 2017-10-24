using System;
using GalaSoft.MvvmLight.Threading;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UwpFcuXUnit.POS
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    /// <remarks>
    /// https://docs.microsoft.com/en-us/windows/uwp/launch-resume/app-lifecycle
    /// </remarks>
    sealed partial class App
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            InitializeComponent();
        }        

        private void CreateRootFrame(
            ApplicationExecutionState previousExecutionState,
            string arguments,
            bool preLaunch,
            Type initialPage)
        {
            Frame rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null)
            {
                DispatcherHelper.Initialize();

                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();

                // don't start socket listening here; needs to come from point in app after logged in

                if (previousExecutionState == ApplicationExecutionState.Terminated)
                {
                    // TODO: Load state from previously suspended application.
                }

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }

            if (preLaunch == false)
            {
                if (rootFrame.Content == null)
                {
                    // When the navigation stack isn't restored navigate to the first page,
                    // configuring the new page by passing required information as a navigation
                    // parameter

                    rootFrame.Navigate(initialPage, arguments);
                }

                // Ensure the current window is active
                Window.Current.Activate();
            }
        }        

        /// <summary>
        /// Invoked when the application is activated by some means other than normal launching.
        /// </summary>
        /// <param name="args">Event data for the event.</param>
        protected override void OnActivated(IActivatedEventArgs args)
        {            
            CreateRootFrame(
                ApplicationExecutionState.Running,
                arguments: null,
                preLaunch: false,
                initialPage: typeof(MainPage));            
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            CreateRootFrame(e.PreviousExecutionState, e.Arguments,
                e.PrelaunchActivated, typeof(MainPage));
        }        
    }
}
