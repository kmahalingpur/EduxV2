import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { Helpers } from '../../../../helpers';


@Component({
selector: "app-controls-base",
templateUrl: "./student-form.component.html",
encapsulation: ViewEncapsulation.None,
})
export class StudentFormComponent implements OnInit {
    model = {};

constructor()  {

}
ngOnInit()  {

}

}