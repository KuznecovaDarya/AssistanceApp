   M S B A M L   `   `   `  ????H  DAssistanceApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:AssistanceAppAssistanceApp  5      #    AssistanceApp.ListTraineePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:AssistanceApp     5      -   5          N? Title$  ListTraineePage??5	       N? 
Background
 ?????.??5      ?  ? RowDefinitions 5   
   ?? 5      $??50 ?6   ?? 5      $??* ?6   ?? 5      $??30 ?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	DGTrainee??5      $??1??6&      AutoGenerateColumns .     
IsReadOnly . 
??????????	#FF0F5EAC$??20(?6?      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Стажер??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6W   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 65   ?? *Trainee.Login+6c   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 auto 6)   
   CellTemplate
 5      ?? 5      .R?5      ??  ??Name$ BtnGo??6<   -   5        ???	#FF0F5EAC$??ПЕРЕЙТИ??5   K   
???????$
??Bold"?6?   $??18(?6?   6?   5      5      5      ?? 5!   
   -   5         ??Name$ id_supervisor??5!      $??0??6+   $
??Left=?6N   ??68   Z? 6N   ?? 5"   
   -   5         ??Name$ 	TxtSearch??5"      $??0??6%   $??30??62   $??Center=?6>   $??0,10,130,10q?6Y   $??Right=?6n   $	??641??6?   $??20(?6?   ?? 5#   
   -   5        $ 	BtnSearch??5#      $??
НАЙТИ??6$   $??0??64   $	??110??6A   $??30??6M   ???	#FF0F5EAC$??Right=?6p   $??Center=?6?   
???????$
??Bold"?6?   $??18(?6?    ? ToolTip$' !Поиск по стажерам.??6?   ?? 5$   
   -   5        $ BtnAdd??5$      $2??,ДОБАВИТЬ НОВОГО СТАЖЕРА??6!   $??2??6C   ???	#FF0F5EAC
???????$
??Bold"?6?   $??18(?6?   $3 -Добавить нового стажера.??6?   5%      5&      