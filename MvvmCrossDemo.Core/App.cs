// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the App type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MvvmCrossDemo.Core
{
    using MvvmCross.Platform.IoC;
    using MvvmCross.Core.ViewModels;
    using MvvmCrossDemo.Core.ViewModels;

    /// <summary>
    /// Define the App type.
    /// </summary>
    public class App : MvxApplication
    {
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public override void Initialize()
        {
            this.CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            //// Start the app with the First View Model.
            this.RegisterAppStart<FirstViewModel>();
        }
    }
}