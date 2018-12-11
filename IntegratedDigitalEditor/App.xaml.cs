using Avalonia;
using Avalonia.Markup.Xaml;

namespace IntegratedDigitalEditor
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
