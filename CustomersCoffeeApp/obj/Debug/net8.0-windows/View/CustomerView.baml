   M S B A M L   `   `   `  ����M  ICustomersCoffeeApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CustomersCoffeeApp.ViewCustomersCoffeeApp.View  5      K*clr-namespace:CustomersCoffeeApp.ConverterCustomersCoffeeApp.Converter  5      *    $CustomersCoffeeApp.View.CustomerView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:CustomersCoffeeApp.View     5      @	converter*clr-namespace:CustomersCoffeeApp.Converter     5        � 	Resources  5
      F  @CustomersCoffeeApp.Converter.NavigationSideToGridColumnConverter "  NavigationSideToGridColumnConv  CustomerDataTemplate �� Orientation" �� ValidatesOnNotifyDataErrors��%  &	        &	        5   
   68   �� 5   
   .R�5      �� $ 
Horizontal=�6   .+�5      �� $
��Bold"�6^   $��0 0 10 0q�6p   ��6    �� *	FirstName+$ False��6p   �� 5      ��6   �� *
LastName+$ False��5      5      5      .��5   
   � .+�5   
   �  � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      �� 5      $
��Auto �6#   .+�5      � ���#777$	��260��5      ��5      �� *NavigationSide+ �� 	Converter# [   � RowDefinitions 5       �� 5!      $
��Auto �6$   �� 5"      $
��Auto �6$   .+�5$      �� $ 
Horizontal=�6   .+�5%      �� $��10q�6   $��75��6)   ��64   �� *
AddCommand+.��5&      �� $ 
Horizontal=�6%   .+�5'      �� $��/Images/add.png��6$   $��18��6=   $��0 0 5 0q�6I   �� 5(      $	��Add��6(   5)      5*      �� 5+      $��Delete��6   $��75��6.   $��
0 10 10 10q�69   ��6M   �� *DeleteCommand+�� 5,      $��
0 10 10 10q�6   ��61   �� *MoveCommand+.��5-      �� $��/Images/move.png��6    $��18��6:   5.      5/      �� 51      #��[ 53      $��1��54      $��
10 0 10 10q�6(   ��51      �� *	Customers+ �� SelectedItem 52      �� *SelectedCustomer+ �� Mode$ TwoWay=�56      57      �� 5:      $��1��6   $��10q�6)   y�5;      �� *IsCustomerSelected+  BooleanToVisiblityConverter# [ .+�5<      �� .��6   
Firstname:6$   �� 5=      ��6   ��  �� Path$  SelectedCustomer.FirstName�$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=��� 5>      .��6   	Lastname:6#   �� 5?      ��6   �� $ SelectedCustomer.LastName�$ TwoWay=�$	 PropertyChanged=��� 5@      $��0 10 0 0q�5A      
 d� 	IsChecked
 5@      �� $" SelectedCustomer.IsDeveloper�$ TwoWay=�$	 PropertyChanged=�.��5A   '   Is developer5C      5D      5E      5F      5G      