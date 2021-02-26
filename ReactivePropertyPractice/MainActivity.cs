
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using System.Reactive.Linq;
using Reactive.Bindings;

namespace ReactivePropertyPractice {
    /// <summary>
    /// M-Activity-VM 
    /// </summary>
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity {

        ///////////////////////////////////////////////////////////////////////////////////////////////
        // Fields

        ViewModel viewModel = new ViewModel();

        ///////////////////////////////////////////////////////////////////////////////////////////////
        // protected Methods [verb]

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);
            //Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var _button1 = FindViewById<Button>(Resource.Id.button1);
            _button1.SetBinding(x => x.Text, viewModel.CounterValue);

            Observable.FromEventPattern(_button1, nameof(Button.Click))
                .SetCommand(viewModel.IncremantCommand);
        }
    }
}
