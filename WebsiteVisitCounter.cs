using System;
using System.Linq;

namespace Theme5;
 
/// <summary>
/// Нестатический класс, описывающий счетчик
/// </summary>
class WebsiteVisitCounter
{
/// <summary>
/// Поле Web-странички
/// </summary>
	string webPage;
/// <summary>
/// Поле Ip-Адреса
/// </summary>
	int ipAddress;
/// <summary>
/// Поле Web-Браузера
/// </summary>
	string webBrowser;
/// <summary>
/// Поле Даты Визита
/// </summary>
	DateTime dateVisit;
/// <summary>
/// Поле Время Визита
/// </summary>
    DateTime timeVisit;
/// <summary>
/// Свойства полей
/// </summary>
    public string WebPage { get => webPage; set => webPage = value; }
    public int IpAddress { get => ipAddress; set => ipAddress = value; }
    public string WebBrowser { get => webBrowser; set => webBrowser = value; }
    public DateTime DateVisit { get => dateVisit; set => dateVisit = value; }
    public DateTime TimeVisit { get => timeVisit; set => timeVisit = value; }
/// <summary>
/// Конструктор без параметров
/// </summary>
    public WebsiteVisitCounter()
	{
	    
	}
/// <summary>
/// Конструктор с параметрами
/// </summary>
/// <param name="webPage"></param>
/// <param name="ipAddress"></param>
/// <param name="webBrowser"></param>
/// <param name="dateVisit"></param>
/// <param name="timeVisit"></param>
    public WebsiteVisitCounter(string webPage, int ipAddress, string webBrowser, DateTime dateVisit, DateTime timeVisit)
	{
	 this.WebPage = webPage;
     this.IpAddress = ipAddress;
     this.WebBrowser = webBrowser;
     this.DateVisit = dateVisit;
     this.TimeVisit = timeVisit;
	}
/// <summary>
/// Метод вывода информации о сотруднике
/// </summary>
    public void Output()
            {
                int visit = DateTime.Now.Time - DateVisit.Time;
				int visit = DateTime.Now.Time - TimeVisit.Time;
                if (DateTime.Now.Month < dateVisit.Month) { age--; }
				if (DateTime.Now.Month < timeVisit.Month) { age--; }
                Console.WriteLine($"Web-Страница- {webPage}\nIp-Адресс- {IpAddress)\nWeb-Браузер- {webBrowser}\nДата Визита- {dateVisit}\nВремя визита- {timeVisit:d}\n");
    
	
     
	
}
