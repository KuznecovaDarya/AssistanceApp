   M S B A M L   `   `   `  ????H  DAssistanceApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:AssistanceAppAssistanceApp  5      %    AssistanceApp.ResultTraineePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:AssistanceApp     5      -   5          N? Title$  ResultTraineePage??5	       N? 
Background
 ?????.??5      ?  ? RowDefinitions 5   
   ?? 5      $??30 ?6   ?? 5      $??* ?6   ?? 5      $??30 ?6   ?? 5      $??* ?6   ?? 5      $??30 ?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGTest??5      $??1??6#      AutoGenerateColumns .     
IsReadOnly . 
??????????	#FF0F5EAC$??20(?6?      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Курс??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6S   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 63   ?? *Course.Name+6_     5      $ Дата??6%   $	 150 6L   	 63   ?? *Date+6Z     5      $ % выполнения??6%   $	 180 6o   	 6;   ?? 
 ?? Path$
 Percents? ?? StringFormat$	 . %??6}   5        5   
   -   5        $ DGCertification??5      $??3??6,    .   . 
??????????	#FF0F5EAC$??20(?6?    5        5      $ Курс??6%   $ * 6S   	 63   ?? *Course.Name+6_     5       $" Допущ./Не допущ.??6%   $	 180 6Z   	 6?   ?? *Status+6h   5"      ?? 5$   
   $.??(Доступ к сертификации??6   $??2??61   $??30??6>    ?? TextAlignment$ Center=?6J   $??20(?6a   ?? 5%   
   $??Тестирование??6   $??0??6(   $??30??65   $ Center=?6A   $??20(?6X   ?? 5&   
   -   5         ??Name$ id??5&      $??0??6    ??6-   Z? ?? 5(   
   -   5         ??Name$ TBPath??5(      $??4??6"   ???	#FF0F5EAC
???????$
??Bold"?6Y   $??18(?6k    ? ToolTip$? ?Введите путь или щелкните два раза для выбора пути сохранения документа.??6y   $??	0,0,300,0q?6?   6?   ?? 5)   
   -   5         ??Name$ BtnGrade??5)      $8??2ОЦЕНКА РЕЗУЛЬТАТОВ СТАЖЕРА??6#   $??4??6H   ???	#FF0F5EAC
???????$
??Bold"?6?   $??18(?6?   $??Right=?6?   $	??300??6?   5*      5+      