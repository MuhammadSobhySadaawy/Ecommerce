import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthRouteGuardService } from 'src/@electronic/services/auth.route.guard.service';
import { AddCategoryComponent } from './Category/add-category/add-category.component';
import { CategorysComponent } from './Category/categorys/categorys.component';
import { EditCategoryComponent } from './Category/edit-category/edit-category.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { HomedashComponent } from './dashboard/homedash/homedash.component';
import { OrdersComponent } from './OrderAdmin/orders/orders.component';
import { AddProductComponent } from './Product/add-product/add-product.component';
import { EditProductComponent } from './Product/edit-product/edit-product.component';
import { ProductImagesComponent } from './Product/product-images/product-images.component';
import { ProductsComponent } from './Product/products/products.component';
import { ProductsapproveComponent } from './ProductsApprove/productsapprove/productsapprove.component';
import { AddSubcategoryComponent } from './SubCategory/add-subcategory/add-subcategory.component';
import { EditSubcategoryComponent } from './SubCategory/edit-subcategory/edit-subcategory.component';
import { SubcategorysComponent } from './SubCategory/subcategorys/subcategorys.component';
import { AddUserComponent } from './Useres_and_Role/add-user/add-user.component';
import { EditUserRoleComponent } from './Useres_and_Role/edit-user-role/edit-user-role.component';
import { UserRolesComponent } from './Useres_and_Role/user-roles/user-roles.component';
import { UsersComponent } from './Useres_and_Role/users/users.component';


const routes: Routes = [
  {path:'dashboard',component:DashboardComponent,canActivate:[AuthRouteGuardService],
  children:[
    {path:'adduser',component:AddUserComponent,canActivate:[AuthRouteGuardService]},
    {path:'userRoles',component:UserRolesComponent,canActivate:[AuthRouteGuardService]},
    {path:'users',component:UsersComponent,canActivate:[AuthRouteGuardService]},
    {path:'products',component:ProductsComponent,canActivate:[AuthRouteGuardService]},
    {path:'edituserRole/:userId/:roleId',component:EditUserRoleComponent,canActivate:[AuthRouteGuardService]},
    {path:'AddProduct',component:AddProductComponent,canActivate:[AuthRouteGuardService]},
    {path:'categorys',component:CategorysComponent,canActivate:[AuthRouteGuardService]},
    {path:'subcategorys',component:SubcategorysComponent,canActivate:[AuthRouteGuardService]},
    {path:'addcategory',component:AddCategoryComponent,canActivate:[AuthRouteGuardService]},
    {path:'editcategory/:id',component:EditCategoryComponent,canActivate:[AuthRouteGuardService]},
    {path:'addsubcategory',component:AddSubcategoryComponent,canActivate:[AuthRouteGuardService]},
    {path:'editsubcategory/:id',component:EditSubcategoryComponent,canActivate:[AuthRouteGuardService]},
    {path:'EditProduct/:id',component:EditProductComponent,canActivate:[AuthRouteGuardService]},
    {path:'ProductImages/:id',component:ProductImagesComponent,canActivate:[AuthRouteGuardService]},
    {path:'productsApprove',component:ProductsapproveComponent,canActivate:[AuthRouteGuardService]},
    {path:'orders',component:OrdersComponent,canActivate:[AuthRouteGuardService]},
    {path:'homedash',component:HomedashComponent,canActivate:[AuthRouteGuardService]},
]
},
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
