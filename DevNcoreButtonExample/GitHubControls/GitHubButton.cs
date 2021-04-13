using System.Windows;
using System.Windows.Controls;

namespace GitHubControls
{
    public class GitHubButton : Button
    {
        static GitHubButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GitHubButton), new FrameworkPropertyMetadata(typeof(GitHubButton)));
        }
    }
}
