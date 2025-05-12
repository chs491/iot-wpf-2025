using CommunityToolkit.Mvvm.ComponentModel;
using NLog;
using System.Diagnostics;
using System.Windows.Threading;

namespace WpfBasicApp01.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        // NLog 객체 생성
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        #region 속성영역
        private string _greeting;

        public string Greeting { 
            get => _greeting;
            set => SetProperty(ref _greeting, value); // CommunityToolKit.Mvvm의 핵심 C++ & == ref
        }

        private string _currentTime;
        
        public string CurrentTime
        {
            get => _currentTime;
            set => SetProperty(ref _currentTime, value);
        }

        private readonly DispatcherTimer _timer; // ViewModel 대해서만 사용

        #endregion

        public MainViewModel()
        {
            _logger.Info("뷰모델 시작!");

            Greeting = "Hello, WPF MVVM!";

            CurrentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += _timer_Tick;
            _timer.Start(); // 타이머 시작
        }

        public void _timer_Tick(object sender, EventArgs e) 
        {

            CurrentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Debug.WriteLine($"[DEBUG] {CurrentTime}");
            _logger.Debug($"[DEBUG] {CurrentTime}");
        }
    }

}
