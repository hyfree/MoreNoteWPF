﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using MoreNoteWPF.Core.Model;

namespace MoreNoteWPF.View
{
    class TabDataTemplateSelector:DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var fe = container as FrameworkElement;
            var obj = item as TabPage;
            DataTemplate dt = null;
            if (obj != null && fe != null)
            {
                switch (obj.Display)
                {
                    case DisplayType.Disk:
                        dt = fe.FindResource("Disk") as DataTemplate;
                        break;
                       case DisplayType.Webpage:
                        dt = fe.FindResource("Webpage") as DataTemplate;
                           break;
                       default:
                           
                           break;

                }
                    
                

            }
            return dt;
        }
    }
}
