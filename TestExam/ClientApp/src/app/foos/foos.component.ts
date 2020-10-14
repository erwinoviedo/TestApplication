import { Component, OnInit } from '@angular/core';
import { Foo, FooService } from './foos.service';

@Component({
  selector: 'app-foos',
  templateUrl: './foos.component.html',
  styleUrls: ['./foos.component.css']
})
export class FoosComponent implements OnInit {
  fooList: Foo[];

  constructor(private fooService: FooService) { }

  ngOnInit() {
    this.fooService.get().subscribe(res => {
      this.fooList = res;
    })
  }

}
