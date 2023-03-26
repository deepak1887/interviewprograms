import { delay, interval, Observable, of, skip, take, timer } from "rxjs";

export class Helpers {
  public static nums(): Observable<number> {
    return of(1,2,3,4,5,6,7);
  }

  public static get7Nums(): Observable<number> {
    return interval(1000).pipe(skip(1), take(7));
  }

  public static getNumsWithDelay(): Observable<number> {

    return timer(1000, 2000).pipe(skip(1), take(3), delay(2000), take(4));
  }

  public static getNums(data: any): Observable<any> {
    let delayReponse = Math.random() * 1500;
    return of(`${data} from getNums`).pipe(delay(delayReponse));
  }
}
