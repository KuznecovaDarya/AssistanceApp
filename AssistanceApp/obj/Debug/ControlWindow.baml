   M S B A M L   `   `   `  ????H  DAssistanceApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:AssistanceAppAssistanceApp  5   	   !    AssistanceApp.ControlWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:AssistanceApp     5   	     ? Icon$  .\Resources\Icon.ico??5   	    ? WindowState$ 	Maximized=?5	   	    ? Title$) #Обучение персонала??5
   	   $	??450??6$   $	??800??61   .??5      ?  ? RowDefinitions 5   
   ?? 5      $??50 ?6   ?? 5      $??* ?6   ?? 5      $??50 ?6   .+?5   
   ?? $??.\Resources\Logo.png??6   $
??Left=?6.   ?? 5   
   $)??#ОБУЧЕНИЕ ПЕРСОНАЛА??6   $??25(?6.   ???	#FF0F70A8$
??Bold"?6S   $??	Underline{?6e   $??Comic Sans MS)?6?   $??Center=?6?   $??Center=?6?   ?? 5   
   -   5         ??Name$ BtnBack??5      $??Right=?6O    ? ToolTip$ Назад.??6?   ??6"   Z? ??68   Z? .??5      ?? $??.\Resources\back.png??6   5      ?? 5   
   -   5        $ BtnExit??5      $??2??6"   $??Right=?6\   $??Center=?6x   $6 0Кнопка выхода из аккаунта.??6?   ??6/   Z? ??6E   Z? .??5      ?? $??.\Resources\exit.png??6   5      ?? 5   
   -   5         ??Name$ Id??5      $??2??66   $??Center=?6C   ??6    Z? 6C   ?? 5   
   -   5        $ BtnMenu??5      $??2??6"   $
??Left=?6\   $??Center=?6w   $, &Кнопка выхода в меню.??6?   ??6/   Z? ??6E   Z? .??5      ?? $??.\Resources\menu.png??6   5        ? 5!   
   -   5        $??	MainFrame??5!   i     ? NavigationUIVisibility$ Hidden=?6   $??1??6\   5"      5#      5$      