   M S B A M L   `   `   `  ????H  DAssistanceApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:AssistanceAppAssistanceApp  5      "    AssistanceApp.PaidCoursePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:AssistanceApp     5      -   5          N? Title$  PaidCoursePage??5	       N? 
Background
 ?????.??5      ?  ? ColumnDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $??* ?6    ? RowDefinitions 5   
   ?? 5      $??50 ?6   ?? 5      $??* ?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGCourse??5      $??1??6%   $??2??62      AutoGenerateColumns .     
IsReadOnly . 
??????????	#FF0F5EAC$??20(?6?      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Для кого??6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 200 6_   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 67   ?? *PaidCourseType.Name+6m     5      $ Название??6%   $	 * 6P   
 67   ?? *Name+6\   5  /System.Windows.Controls.DataGridHyperlinkColumn  5      $  Ссылка на курс??6*   $	 * 6[   
 6B   ?? *Link+6g   5      ?? 5   
   -   5        $??CBFiltr??5      $??20(?6"   $??30??60   $??Center=?6<    ?? DisplayMemberPath$
 Name??6    ?? SelectedValuePath$ Id_PaidCourseType??6?   $??0,10,130,10q?6?    ?? SelectedItem 6W   ?? *PaidCourseType+6?   ?? 5    
   -   5         ??Name$ BtnFiltr??5       $
??ОК??6#   $??30??60   ???	#FF0F5EAC$??Center=?6S   
???????$
??Bold"?6?   $??18(?6?   $??
0,10,10,10q?6?   $??Right=?6?   $	??100??6?   ?? 5"   
   -   5         ??Name$ 	TxtSearch??5"      $??20(?6%   $??0??63   $??1??6@   $??30??6P   $??Center=?6\   $??0,10,130,10q?6w   ?? 5#   
   -   5        $ 	BtnSearch??5#      $??
НАЙТИ??6$   $??0??64   $??1??6A   $??30??6Q   ???	#FF0F5EAC$??Center=?6t   
???????$
??Bold"?6?   $??18(?6?   $
??0,10q?6?   $??Right=?6?   $	??100??6  5$      5%      