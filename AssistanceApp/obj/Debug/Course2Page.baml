   M S B A M L   `   `   `  ????H  DAssistanceApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:AssistanceAppAssistanceApp  5          AssistanceApp.Course2Page   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:AssistanceApp     5      -   5          N? Title$  Course2Page??5	       N? 
Background
 ?????.??5      ?  ? ColumnDefinitions 5   
   ?? 5      $	??250 ?6   ?? 5      $??* ?6    ? RowDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $??50 ?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGTopic??5      $??0??6$   $??0??61      AutoGenerateColumns .     
IsReadOnly . 
??????????	#FF0F5EAC$??20(?6?      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6>   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   ?? *Name+
   ElementStyle
 5      ?? 5       ?? 
TargetType" ??6    .?5      ??  ?? Property ? ?? ?? Value$
 Wrap=?6=   6L   5      5      5       ?? 5"   
   -   5         ??Name$ 	RTBCourse??5"       ?? 
IsReadOnly . $??2??6;   $??1??6L   ?? 5$   
   -   5         ??Name$ BtnRead??5$      $??ЧИТАТЬ??6"   ???	#FF0F5EAC
???????$
??Bold"?6s   $??20(?6?   $??1??6?   5%      5&      