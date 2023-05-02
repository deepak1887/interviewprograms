import { Component } from "@angular/core";

@Component({
  selector: 'app-message',
  standalone: true,
  template: `
    <div>{{message}}</div>
  `
})
export class MessageComponent {
  public message = '';
}
