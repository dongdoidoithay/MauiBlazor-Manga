
using Microsoft.AspNetCore.Components;

namespace MangaReader.UI;
public class MyComponentBase : ComponentBase
{
    //    [Inject]
    //    public ILoginDataStorage _loginDataStorage { get; set; } = null!;

    public bool IsLogin => true;// _loginDataStorage.GetUsername().IsNotEmpty();
    public bool IsNotLogin => !IsLogin;
}