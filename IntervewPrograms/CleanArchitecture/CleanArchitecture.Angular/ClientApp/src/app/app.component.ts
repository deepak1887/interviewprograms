import { Component, OnChanges, SimpleChanges } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent implements OnChanges {
  ngOnChanges(changes: SimpleChanges): void {
      throw new Error('Method not implemented.');
  }
  title = 'app';
}
