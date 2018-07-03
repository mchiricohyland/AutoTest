using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hyland.UIAutomation;
using Hyland.WPF.UIAutomation.Core;
using Hyland.WPF.UIAutomation.Core.Controls;
using Hyland.WPF.UIAutomation.Core.Search;
using NUnit.Framework;

namespace AutoTestBlank
{
    [TestFixture]
    class AutoTest2
    {
        static void Main()
        {
            MethodName();
            MethodName2();
            MethodName3();
        }
        [Test]
         public static void MethodName()
        {
            var myApp = new Application("C:\\TestApp\\UIAutomation.TestApp.exe");
            var appWindow = myApp.Start();
            var editBox = appWindow.Locate<Edit>(Found.ByAutomationId("textboxAutomationId"));
            editBox.Value = "Hello World";

            Assert.That(editBox.Value, Is.EqualTo("Hello World"));

            myApp.Close();
        }
        [Test]
        public static void MethodName2()
        {
            var myApp = new Application("C:\\TestApp\\UIAutomation.TestApp.exe");
            var appWindow = myApp.Start();
            var editBox = appWindow.Locate<CheckBox>(Found.ByAutomationId("checkboxAutomationId"));
            editBox.Check();

            Assert.That(editBox.IsChecked, Is.True);

            myApp.Close();
            
        }
        [Test]
        public static void MethodName3()
        {
            var myApp = new Application("C:\\TestApp\\UIAutomation.TestApp.exe");
            var appWindow = myApp.Start();
            var editBox = appWindow.Locate<ComboBox>(Found.ByAutomationId("comboboxAutomationId"));
            //editBox.GetSelection

            Assert.That(editBox.GetSelection, Is.EqualTo(0));

            myApp.Close();

        }
    }
}
