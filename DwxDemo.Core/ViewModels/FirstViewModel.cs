// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the FirstViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Net.Http;

namespace DwxDemo.Core.ViewModels
{
    using System.Windows.Input;
    using MvvmCross.Core.ViewModels;

    /// <summary>
    /// Define the FirstViewModel type.
    /// </summary>
    public class FirstViewModel : BaseViewModel
    {
        /// <summary>
        /// Backing field for my property.
        /// </summary>
        private string myProperty = "Mvx Ninja Coder!";

        /// <summary>
        ///  Backing field for my command.
        /// </summary>
        private MvxCommand myCommand;

        /// <summary>
        /// Gets or sets my property.
        /// </summary>
        public string MyProperty
        {
            get { return this.myProperty; }
            set { this.SetProperty(ref this.myProperty, value, () => this.MyProperty); }
        }

        /// <summary>
        /// Gets My Command.
        /// <para>
        /// An example of a command and how to navigate to another view model
        /// Note the ViewModel inside of ShowViewModel needs to change!
        /// </para>
        /// </summary>
        public ICommand MyCommand => this.myCommand ?? (this.myCommand = new MvxCommand(this.Show));

        /// <summary>
        /// Show the view model.
        /// </summary>
        public async void Show()
        {
            var text = await new HttpClient().GetStringAsync("http://www.randomtext.me/download/txt/");
            MyProperty = text;
        }
    }
}
