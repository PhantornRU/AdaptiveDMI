using System.Windows.Controls;

namespace AdaptiveDMI.Contracts.Services;

public interface IPageService
{
    Type GetPageType(string key);

    Page GetPage(string key);
}
