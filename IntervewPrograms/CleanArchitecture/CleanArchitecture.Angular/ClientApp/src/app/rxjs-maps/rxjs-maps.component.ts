import { Component, OnInit } from "@angular/core";
import { concatMap, delay, exhaustMap, forkJoin, interval, map, mergeAll, mergeMap, Subscription, switchMap, take, timer } from "rxjs";
import { Helpers } from "../Helpers/helpers";

@Component({
  selector: 'rxjs-maps',
  templateUrl: './rxjs-maps.component.html'
})
export class RxjsMapsComponent implements OnInit {
  

  private obs1 = interval(500).pipe(take(20)); //.5 *20 = 10
  private obs1Subscription = Subscription.EMPTY;
  public obs1Data: any[] = [];

  private obs2 = interval(1000).pipe(take(10)); //1*10 = 10
  private obs3 = interval(1500).pipe(take(5)); // 1.5*5 = 7.5
  private obs4 = interval(2000).pipe(take(2)); //2*2 = 4
  private obs5 = interval(2500).pipe(take(5));
  private obs6 = interval(3000).pipe(take(5));


  ngOnInit(): void {
    this.obs1Data = [];
  }

  public startObs1(): void {
    //this.obs1Subscription = forkJoin([this.obs1, this.obs2, this.obs3, this.obs4]).subscribe((x) => {
    //  console.log(x);
    //})
    this.obs1Subscription = Helpers.nums().pipe(map(x => Helpers.getNums(x)), mergeAll(2)).subscribe((x) => {
      //this.obs1Data.push(x);
      console.log(x);
    })
  }

  public stopObs1() {
    this.obs1Subscription.unsubscribe();
  }

}
