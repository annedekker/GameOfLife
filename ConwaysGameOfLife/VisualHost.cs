using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ConwaysGameOfLife
{
    class VisualHost : FrameworkElement
    {
        public VisualCollection Visuals;

        public VisualHost()
        {
            Visuals = new VisualCollection(this);
        }

        protected override Visual GetVisualChild(int index)
        {
            return Visuals[index];
        }

        protected override int VisualChildrenCount
        {
            get
            {
                return Visuals.Count;
            }
        }
    }
}
