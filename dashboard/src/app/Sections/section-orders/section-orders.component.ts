import { Component, OnInit } from '@angular/core';
import { Order } from 'src/app/shared/order';

@Component({
  selector: 'app-section-orders',
  templateUrl: './section-orders.component.html',
  styleUrls: ['./section-orders.component.css']
})
export class SectionOrdersComponent implements OnInit {

  constructor() { }
  orders: Order[] = [
    {
      id: 1,
      customer: { id: 1, name: 'Sam', state: ' NY', email: 'BiDashboard@example.com' },
      total: 230, placed: new Date(2020, 12, 18), fulfilled: new Date(2020, 12, 25),
    },
    {
      id: 2,
      customer: { id: 2, name: 'Sam', state: ' NY', email: 'BiDashboard@example.com' },
      total: 230, placed: new Date(2020, 12, 18), fulfilled: new Date(2020, 12, 25),
    },
    {
      id: 3,
      customer: { id: 4, name: 'Sam', state: ' NY', email: 'BiDashboard@example.com' },
      total: 230, placed: new Date(2020, 12, 18), fulfilled: new Date(2020, 12, 25),
    },
    {
      id: 4,
      customer: { id: 4, name: 'Sam', state: ' NY', email: 'BiDashboard@example.com' },
      total: 230, placed: new Date(2020, 12, 18), fulfilled: new Date(2020, 12, 25),
    },
    {
      id: 5,
      customer: { id: 5, name: 'Sam', state: ' NY', email: 'BiDashboard@example.com' },
      total: 230, placed: new Date(2020, 12, 18), fulfilled: new Date(2020, 12, 25),
    },




  ];

  ngOnInit(): void {
  }

}
