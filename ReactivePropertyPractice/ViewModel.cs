
using System;
using System.Linq;
using System.Reactive.Linq;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;

namespace ReactivePropertyPractice {
    /// <summary>
    /// ViewModel for app
    /// </summary>
    public class ViewModel {

        ///////////////////////////////////////////////////////////////////////////////////////////////
        // Fields

        Model model = new Model();

        ///////////////////////////////////////////////////////////////////////////////////////////////
        // Constructor

        public ViewModel() {
            CounterValue = model
                .ObserveProperty(x => x.Count)
                .Select(x => x.ToString())
                .ToReadOnlyReactiveProperty();

            IncremantCommand = new ReactiveCommand();
            IncremantCommand.Subscribe(_ => model.Increment());
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////
        // Properties [noun, adjective] 

        public ReadOnlyReactiveProperty<string> CounterValue {
            get;
        }

        public ReactiveCommand IncremantCommand {
            get;
        }
    }
}
