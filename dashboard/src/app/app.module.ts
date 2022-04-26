import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { NgChartsModule } from 'ng2-charts';
import { HttpClientModule } from '@angular/common/http';

//Components
import { AppComponent } from './app.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { SectionSalesComponent } from './Sections/section-sales/section-sales.component';
import { SectionOrdersComponent } from './Sections/section-orders/section-orders.component';
import { SectionHealthComponent } from './Sections/section-health/section-health.component';
import { BarChartComponent } from './charts/bar-chart/bar-chart.component';
import { PieChartComponent } from './charts/pie-chart/pie-chart.component';
import { LineChartComponent } from './charts/line-chart/line-chart.component';
import { PaginationComponent } from './pagination/pagination.component';
//Services
import { SalesDataService } from 'src/services/sales-data.service';

@NgModule({
  declarations: [
    AppComponent,
    SidebarComponent,
    SectionSalesComponent,
    SectionOrdersComponent,
    SectionHealthComponent,
    BarChartComponent,
    PieChartComponent,
    LineChartComponent,
    PaginationComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgChartsModule,
    HttpClientModule

  ],
  providers: [ SalesDataService],
  bootstrap: [AppComponent]
})
export class AppModule { }
