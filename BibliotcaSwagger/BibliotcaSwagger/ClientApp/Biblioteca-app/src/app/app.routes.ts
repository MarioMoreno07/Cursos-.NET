import { Routes } from '@angular/router';
import { LibrosComponent } from './pages/libros/libros.component';
import { UsuariosComponent } from './pages/usuarios/usuarios.component';
import { PrestamosComponent } from './pages/prestamos/prestamos.component';
//import { AuthComponent } from './pages/login/auth.component';

export const routes: Routes = [
  { path: '', redirectTo: 'libros', pathMatch:'full'},
  { path: 'libros', component: LibrosComponent },
  { path: 'usuarios', component: UsuariosComponent },
  { path: 'prestamos', component: PrestamosComponent },
  //{ path: 'login', component: AuthComponent },
];
