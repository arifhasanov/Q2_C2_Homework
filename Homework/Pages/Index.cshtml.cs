namespace Homework.Pages;
public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public string text = "    Предложение    один  Теперь предложение    два   Предложение три ";

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;

        //first we delete all additional spaces
        RegExHelper(ref text, @"[ ]{2,}", " ");
        //we remove the space from beginning
        RegExHelper(ref text, @"^\s*", ""); 
        //we remove the space from end
        RegExHelper(ref text, @"\s*$", ""); 
        //finding all capital letters and looking one char before
        RegExHelper(ref text, @".(?=[Й|Ц|У|К|Е|Н|Г|Ш|Щ|З|Х|Ф|Ы|В|А|П|Р|О|Л|Д|Ж|Э|Я|Ч|С|М|И|Т|Ь|Б|Ю])", ".\n"); 
        //put a point at the end
        RegExHelper(ref text, @"$", ".");
    }

    void RegExHelper(ref string text, string changeFrom, string changeTo)
    {
        Regex regex = new Regex(changeFrom, RegexOptions.None);
        text = regex.Replace(text, changeTo);
    }

    public void OnGet()
    {

    }
}
