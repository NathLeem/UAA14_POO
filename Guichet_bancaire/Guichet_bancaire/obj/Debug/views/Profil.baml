   M S B A M L   `   `   `  ����K  GGuichet_bancaire, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Guichet_bancaire.viewsGuichet_bancaire.views  5      #    Guichet_bancaire.views.Profil   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:Guichet_bancaire.views     5        N� 
FontFamily$  arial)�5   0    N� FontSize$ 25(�6C    N� Title$ Profil��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $	��Nom��6   $��Center=�6   $��Center=�6<   �� 5   
   -   5         ��Name$ txtNom��5      $��1��6"   $��10q�62   �� 5   
   $��Prénom��6   $��1��6"   $��Center=�6/   $��Center=�6L   �� 5   
   -   5        $ 	txtPrenom��5      $��1��6%   $��1��62   $��10q�6B   �� 5!   
   $��Email��6   $��2��6!   $��Center=�6.   $��Center=�6K   �� 5"   
   -   5        $ txtEmail��5"      $��2��6$   $��1��61   $��10q�6A   �� 5$   
   $��Mot de passe��6   $��3��6(   $��Center=�65   $��Center=�6R   �� 5%   
   -   5        $ txtMDP��5%      $��3��6"   $��1��6/   $��10q�6?   �� 5'   
   $��Compte Bancaire��6   $��4��6+   $��Center=�68   $��Center=�6U   �� 5(   
   -   5         ��Name$ 
listCompte��5(      $��4��6&   $��1��63   $��10q�6C   �� 5*   
   -   5         ��Name$ btnModif��5*      $��Modifier��6#   $��5��66   $��100,10,100,10q�6C   �� 5+   
   -   5        $ 	btnRetour��5+      $��Retour��6$   $��5��65   $��1��6B   $��100,10,100,10q�6R   5,      5-      