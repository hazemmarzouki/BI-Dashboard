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
    { data: [35, 25, 46, 11, 57, 25], label: 'NY', tension: 0.5,fill: true },
    { data: [45, 14, 55, 35, 47, 31], label: 'FL', tension: 0.5,fill: true },
    { data: [25, 48, 18, 36, 15, 45], label: 'AZ' , tension: 0.5,fill: true}
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
