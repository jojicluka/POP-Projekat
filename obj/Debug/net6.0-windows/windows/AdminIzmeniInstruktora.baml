   M S B A M L   `   `   `  ????@  <bench, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:bench.windowsbench.windows  5   	   *    $bench.windows.AdminIzmeniInstruktora   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:bench.windows     5   	     ? Title$(  "bench - Admin / Izmeni Instruktora??5   	   $	??800??64   $	??450??6A   .??5	      ? ??5
   
   ?? 5       ?? EndPoint$ 0.5,1&?6"    ?? 
StartPoint$ 0.5,0&?63   .??5      ?  ? Color$ Black??6    ? Offset$ 0.323Q?6-   ? 5      $ 	#FF1F1E1A??6   $ 0.957Q?61   5      .+?5   
   ?? $
??Left=?6   $	??100??6+   $??885,-18,0,0q?68   $	??Top=?6M   $	??100??6e   ?? 5   
   $??140,26,164,660q?6   $??/benchlogo.png??6(   $
??Fill=?6@   ?? 5   
   -   5         ??Name$ closeBtn??5      $??Zatvori??6#   $
??Left=?65   $??30??6P   $??101,723,0,0q?6\   $	??Top=?6q   $	??112??6?   ???	#FF353131$
??Bold"?6?   6?   ?? 5   
   $??Ime: ??6   $
??Left=?6    $??32??6;   $??
82,212,0,0q?6G   $	??Top=?6[   $??76??6s   
???????$
??Bold"?6?   $??Arial Black)?6?   $??16(?6?   ?? 5   
   $??	Prezime: ??6   $
??Left=?6$   $??32??6?   $??
82,249,0,0q?6K   $	??Top=?6_   $??95??6w   
???????$
??Bold"?6?   $??Arial Black)?6?   $??16(?6?   ?? 5   
   $??JMBG: ??6   $
??Left=?6!   $??32??6<   $??
82,286,0,0q?6H   $	??Top=?6\   $??76??6t   
???????$
??Bold"?6?   $??Arial Black)?6?   $??16(?6?   ?? 5   
   $??Pol: ??6   $
??Left=?6    $??32??6;   $??
82,323,0,0q?6G   $	??Top=?6[   $??76??6s   
???????$
??Bold"?6?   $??Arial Black)?6?   $??16(?6?   ?? 5   
   $??Ulica: ??6   $
??Left=?6"   $??32??6=   $??
82,360,0,0q?6I   $	??Top=?6]   $??76??6u   
???????$
??Bold"?6?   $??Arial Black)?6?   $??16(?6?   ?? 5   
   $??Broj: ??6   $
??Left=?6!   $??32??6<   $??
82,397,0,0q?6H   $	??Top=?6\   $??76??6t   
???????$
??Bold"?6?   $??Arial Black)?6?   $??16(?6?    J? RenderTransformOrigin$ 
0.48,1.956&?6?   ?? 5   
   $??Grad: ??6   $
??Left=?6!   $??32??6<   $??
82,434,0,0q?6H   $	??Top=?6\   $??76??6t   
???????$
??Bold"?6?   $??Arial Black)?6?   $??16(?6?   $ 
0.48,1.956&?6?   ?? 5   
   $??Drzava: ??6   $
??Left=?6#   $??32??6>   $??
82,471,0,0q?6J   $	??Top=?6^   $??76??6v   
???????$
??Bold"?6?   $??Arial Black)?6?   $??16(?6?   $ 
0.48,1.956&?6?   ?? 5   
   $??Email: ??6   $
??Left=?6"   $??32??6=   $??
82,508,0,0q?6I   $	??Top=?6]   $??76??6u   
???????$
??Bold"?6?   $??Arial Black)?6?   $??16(?6?   $ 
0.48,1.956&?6?   ?? 5   
   $??	Lozinka: ??6   $
??Left=?6$   $??32??6?   $??
82,545,0,0q?6K   $	??Top=?6_   $??95??6w   
???????$
??Bold"?6?   $??Arial Black)?6?   $??16(?6?   $ 
0.48,1.956&?6?   ?? 5   
   -   5        $ editBtn??5      $??Izmeni??6"   $
??Left=?63   $??30??6N   $??240,723,0,0q?6Z   $	??Top=?6o   $	??112??6?   ???	#FF353131$
??Bold"?6?   6?   ?? 5    
   -   5         ??Name$ 
imeTextBox??5       $
??Left=?6&   $??16??6A   $??192,220,0,0q?6M    ?? TextWrapping$
 Wrap=?6b   $??TextBox??6v   $	??Top=?6?   $	??208??6?   ?? 5!   
   -   5        $ prezimeTextBox??5!      $
??Left=?6*   $??16??6E   $??192,257,0,0q?6Q   $
 Wrap=?6f   $??TextBox??6z   $	??Top=?6?   $	??208??6?   ?? 5"   
   -   5        $ jmbgTextBox??5"      $
??Left=?6'   $??16??6B   $??192,294,0,0q?6N   $
 Wrap=?6c   $??TextBox??6w   $	??Top=?6?   $	??208??6?   ?? 5#   
   -   5        $ ulicaTextBox??5#      $
??Left=?6(   $??16??6C   $??192,368,0,0q?6O   $
 Wrap=?6d   $??TextBox??6x   $	??Top=?6?   $	??208??6?   ?? 5$   
   -   5        $ brojTextBox??5$      $
??Left=?6'   $??16??6B   $??192,405,0,0q?6N   $
 Wrap=?6c   $??TextBox??6w   $	??Top=?6?   $	??208??6?   ?? 5%   
   -   5        $ gradTextBox??5%      $
??Left=?6'   $??16??6B   $??192,442,0,0q?6N   $
 Wrap=?6c   $??TextBox??6w   $	??Top=?6?   $	??208??6?   ?? 5&   
   -	   5        $ drzavaTextBox??5&      $
??Left=?6)   $??16??6D   $??192,479,0,0q?6P   $
 Wrap=?6e   $??TextBox??6y   $	??Top=?6?   $	??208??6?   ?? 5'   
   -
   5        $ mailTextBox??5'      $
??Left=?6'   $??16??6B   $??192,516,0,0q?6N   $
 Wrap=?6c   $??TextBox??6w   $	??Top=?6?   $	??208??6?   ?? 5(   
   -   5        $ passwordTextBox??5(      $
??Left=?6+   $??16??6F   $??192,553,0,0q?6R   $
 Wrap=?6g   $??TextBox??6{   $	??Top=?6?   $	??208??6?   ?? 5)   
   -   5        	 ??Name$	 polCombo??5)      $
??Left=?6%   $??24??6@   $??192,329,0,0q?6L   $	??Top=?6a   $	??208??6y   
 ?? SelectedIndex$
 0??6?   .@?5*      ?? .??6   Muski6"   ?? 5+      .??6   Zenski6#   5,      5-      5.      