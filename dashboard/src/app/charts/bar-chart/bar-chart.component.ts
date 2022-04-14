import { Component, OnInit } from '@angular/core';



const Sample_BarChart_Data : any[] =[
  {data:[65,59,80,85,56,54,30],
    label:'November Sales ',
    backgroundColor: "rgba(55,80,120,0.4)",
    hoverBorderColor: "rgba(55,99,132,1)",},

  {data:[45,78,25,15,91,50,60],
    label:'December Sales '}
];

const Sample_BarChart_labels : string[] =[
  'week1','week2','week3','week4','week5','week6','week7'
]; 


@Component({
  selector: 'app-bar-chart',
  templateUrl: './bar-chart.component.html',
  styleUrls: ['./bar-chart.component.css']
})
export class BarChartComponent implements OnInit {

  constructor() { }

  public barChartData: any[] = Sample_BarChart_Data;
  public barChartLabels : string[] = Sample_BarChart_labels;
  public barChartLegend = true ;
  public barChartOptions: any = {
    scaleShowVerticalLines : false,
    responsive:true,
 
  };
  
  
  ngOnInit(): void {
  }

}
