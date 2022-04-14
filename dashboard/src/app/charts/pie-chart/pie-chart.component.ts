import { Component, OnInit } from '@angular/core';
import { ChartDataset, ChartType } from 'chart.js';

@Component({
  selector: 'app-pie-chart',
  templateUrl: './pie-chart.component.html',
  styleUrls: ['./pie-chart.component.css']
})
export class PieChartComponent implements OnInit {

  public pieChartLabels: string[] = ['John', 'Adam','davis','sam','sarra'];
  public pieChartData: ChartDataset[] = [
    { data: [350,450,120,50,200],
      backgroundColor:["#26547c","#6bc4ff","#66fff7"],
      borderColor:'#111',
    }
    
    
    ];
  public pieChartLegend = true;
  public pieChartType: ChartType = 'doughnut';
  public pieChartOptions : any = {
    responsive:true,

  };


  constructor() { }

  ngOnInit(): void {
  }

}
