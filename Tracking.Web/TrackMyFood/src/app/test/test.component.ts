import { Component, OnInit, TemplateRef } from '@angular/core';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class TestComponent{

    modalRef: BsModalRef;
    constructor(private modalService: BsModalService) {}
   
    openModal(template: TemplateRef<any>) {
      this.modalRef = this.modalService.show(template);
    }
  }
