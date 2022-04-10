import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SectionHealthComponent } from './Sections/section-health/section-health.component';
import { SectionOrdersComponent } from './Sections/section-orders/section-orders.component';
import { SectionSalesComponent } from './Sections/section-sales/section-sales.component';

const routes: Routes = [
  { path: 'sales', component: SectionSalesComponent },
  { path: 'orders', component: SectionOrdersComponent },
  { path: 'health', component: SectionHealthComponent },
  { path: '', redirectTo:'/sales',pathMatch:'full'},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
