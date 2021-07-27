using Microsoft.Xaml.Behaviors;
using Syncfusion.UI.Xaml.Scheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SchedulerWPF
{
    public class ScheduleBehavior : Behavior<Grid>
    {
        Grid grid;
        StackPanel stackpanel;
        ComboBox AppointmentEditFlagComboBox;
        protected override void OnAttached()
        {
            grid = this.AssociatedObject as Grid;
            stackpanel = grid.Children[1] as StackPanel;
            AppointmentEditFlagComboBox = stackpanel.Children[0] as ComboBox;
            AppointmentEditFlagComboBox.ItemsSource = Enum.GetValues(typeof(AppointmentEditFlag));
        }

       
        protected override void OnDetaching()
        {
            base.OnDetaching();
            grid = null;
            stackpanel = null;
            AppointmentEditFlagComboBox = null;
        }
    }
}
