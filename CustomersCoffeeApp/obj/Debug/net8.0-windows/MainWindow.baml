   M S B A M L   `   `   `  ����M  ICustomersCoffeeApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CustomersCoffeeAppCustomersCoffeeApp  5   	   I)clr-namespace:CustomersCoffeeApp.ControlsCustomersCoffeeApp.Controls  68   A%clr-namespace:CustomersCoffeeApp.ViewCustomersCoffeeApp.View  5   	   K*clr-namespace:CustomersCoffeeApp.ViewModelCustomersCoffeeApp.ViewModel  5   	   #    CustomersCoffeeApp.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:CustomersCoffeeApp     5   	   >controls)clr-namespace:CustomersCoffeeApp.Controls     68   6view%clr-namespace:CustomersCoffeeApp.View     5   	   @	viewModel*clr-namespace:CustomersCoffeeApp.ViewModel     5   	     � Title$  
MainWindow��5
   	   $	��653��6   $
��1220��6)    � 	Resources 5       �� DataType5   /CustomersCoffeeApp.ViewModel.CustomersViewModel*   $CustomersCoffeeApp.View.CustomerView4   .CustomersCoffeeApp.ViewModel.ProductsViewModel*   $CustomersCoffeeApp.View.ProductsView��%�   (��       5      *, +)(�� 2     5      *, +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5"   
   o� $��20(�6   .@�5#      m� $��_View��6   .@�5$      m� $��
_Customers��6    m� Command 6/   �� *SelectViewModelCommand+ m� CommandParameter 6Z   �� *CustomersViewModel+m� 5%      $��	_Products��6    6.   �� *SelectViewModelCommand+ 6Y   �� *ProductsViewModel+5&      5'      /   )CustomersCoffeeApp.Controls.HeaderControl  5*   
   $��1��6!   �� 5,   
   $��2��6   ��6&   �� *SelectedViewModel+5-      �� 5/   
   $��3��6   .@�50      �� $��20(�6      HeaderBackgroundBrush#��[  6*   $�� (c) Wired Brain Coffee��6^   51      52      53      