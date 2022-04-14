import { Component, OnInit } from '@angular/core';
import { ChartDataset,ChartType} from 'chart.js';

@Component({
  selector: 'app-line-chart',
  templateUrl: './line-chart.component.html',
  styleUrls: ['./line-chart.component.css']
})
export class LineChartComponent implements OnInit {


  constructor() { }

  public lineChartData: ChartDataset[] = [ 
    { data: [85, 72, 78, 75, 77, 75], label: 'Crude oil prices', tension: 0.5,fill: true },
    { data: [45, 42, 88, 35, 47, 41], label: 'oil prices', tension: 0.5,fill: true },
    { data: [75, 48, 48, 36, 15, 45], label: 'Crud' , tension: 0.5,fill: true}
  ];

  lineChartLabels: string[] = ['January', 'February', 'March', 'April', 'May', 'June'];

  lineChartOptions = {
    responsive: true,
  };
  lineChartType :ChartType= 'line';
  lineChartLengend = true ;

  ngOnInit(): void {
  }

}
