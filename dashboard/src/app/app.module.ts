import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { SectionSalesComponent } from './Sections/section-sales/section-sales.component';
import { SectionOrdersComponent } from './Sections/section-orders/section-orders.component';
import { SectionHealthComponent } from './Sections/section-health/section-health.component';

@NgModule({
  declarations: [
    AppComponent,
    SidebarComponent,
    SectionSalesComponent,
    SectionOrdersComponent,
    SectionHealthComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
