import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-bottom-frame',
  templateUrl: './bottom-frame.component.html',
  styleUrls: ['./bottom-frame.component.css']
})
export class BottomFrameComponent implements OnInit {

  constructor() { }

  openGit() {
    window.open("https://github.com/frankAwesome/ITRW324Group21")
  }

  openSlack() {
    window.open("https://app.slack.com/client/TLLKMFSTY/GLJURMYH0")
  }

  ngOnInit() {
  }

}
