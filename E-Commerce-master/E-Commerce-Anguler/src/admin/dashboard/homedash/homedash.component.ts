import { Component, OnInit } from '@angular/core';
import { countAdmin } from 'src/@electronic/model/countAdmin';
import { AdminService } from 'src/@electronic/services/admin.service';

@Component({
  selector: 'app-homedash',
  templateUrl: './homedash.component.html',
  styleUrls: ['./homedash.component.scss']
})
export class HomedashComponent implements OnInit {

  constructor(private service:AdminService) { }
count!:countAdmin;
  ngOnInit(): void {
    this.service.CountAdmin().subscribe(e=>{
      this.count=e;

    })
  }

}
