   M S B A M L   `   `   `  ����K  GGuichet_bancaire, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Guichet_bancaire.viewsGuichet_bancaire.views  5      &     Guichet_bancaire.views.Operation   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:Guichet_bancaire.views     5        N� 
FontFamily$  arial)�5   0    N� Title$ 	Operation��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��Compte��6   $��Center=�6"   $��25(�6=   �� 5   
   -   5         ��Name$ 
listCompte��5      $��100,10,100,10q�6&   ��5      �� 5      .R�5      �� ��6    �� *numero+5       5"      �� 5$   
   -   5         ��Name$ 	btnProfil��5$      $��Profil��6$   $��1��65   $��Right=�6E   $��10,15,10,15q�6a   $��20(�6v   �� 5&   
   $��Virement��6   $��1��6$   $��30(�61   �� 5'   
   $��Valeur de la transaction��6   $��1��64   $��1��6A   $	��Top=�6Q   $��20(�6i   �� 5(   
   -   5         ��Name$ txtVirement��5(      $��1��6'   $��1��64   $��Bottom=�6D   $��
10,0,10,10q�6_   �� 5*   
   $��Retrait��6   $��2��6#   $��30(�60   �� 5+   
   $��Valeur de la transaction��6   $��2��64   $��1��6A   $	��Top=�6Q   $��20(�6i   �� 5,   
   -   5        $ 
txtRetrait��5,      $��2��6&   $��1��63   $��Bottom=�6C   $��
10,0,10,10q�6^   �� 5.   
   $��Transfère vers:��6   $��3��6+   $��25(�68   �� 5/   
   -   5        $ listTransfere��5/      $��3��6)   $��10,35,10,10q�66   ��50      �� 51      .R�52      �� ��6    �� *numero+53      55      �� 56   
   $��Valeur de la transaction��6   $��3��64   $��1��6A   $	��Top=�6Q   $��20(�6i   �� 57   
   -   5        $ txtTransfere��57      $��3��6(   $��1��65   $��Bottom=�6E   $��
10,0,10,10q�6`   �� 59   
   -   5        $ 
btnValider��59      $��Valider��6%   $��4��67   $��100,10,100,10q�6D   $��25(�6[   �� 5:   
   -   5        $ 	btnRetour��5:      $��Retour��6$   $��4��65   $��1��6B   $��100,10,100,10q�6R   $��25(�6i   5;      5<      