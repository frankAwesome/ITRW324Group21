import { BrowserModule } from '@angular/platform-browser';
import { NgModule, ErrorHandler } from '@angular/core';
import { AppComponent } from './app.component';
import { NavigationComponent } from './navigation/navigation.component';
import { MDBBootstrapModule } from 'angular-bootstrap-md';
import { HttpClientModule } from '@angular/common/http';
import { DataService } from "./data.service";
import { RouterModule, Routes } from "@angular/router";
import { HomePageComponent } from './home-page/home-page.component';
import { DesktopPageComponent } from './desktop-page/desktop-page.component';
import { MobilePageComponent } from './mobile-page/mobile-page.component';
import { DownloadsPageComponent } from './downloads-page/downloads-page.component';
import { ManualPageComponent } from './manual-page/manual-page.component';
import { BottomFrameComponent } from './bottom-frame/bottom-frame.component';
import { FileTransferPageComponent } from './file-transfer-page/file-transfer-page.component';
import { VideoCallPageComponent } from './video-call-page/video-call-page.component';
import { VoiceNotePageComponent } from './voice-note-page/voice-note-page.component';

const appRoutes: Routes = [
  { path: 'home', component: HomePageComponent },
  { path: 'desktop', component: DesktopPageComponent},
  { path: 'mobile', component: MobilePageComponent},
  { path: 'downloads', component: DownloadsPageComponent},
  { path: 'manual', component: ManualPageComponent},
  { path: 'file-transfer', component: FileTransferPageComponent},
  { path: 'video-call', component: VideoCallPageComponent},
  { path: 'voice-note', component: VoiceNotePageComponent}

];

@NgModule({
  declarations: [
    AppComponent,
    NavigationComponent,
    HomePageComponent,
    DesktopPageComponent,
    MobilePageComponent,
    DownloadsPageComponent,
    ManualPageComponent,
    BottomFrameComponent,
    FileTransferPageComponent,
    VideoCallPageComponent,
    VoiceNotePageComponent
  ],
  imports: [
    MDBBootstrapModule.forRoot(),
    RouterModule.forRoot(
      appRoutes,
      {enableTracing: true}
    ),
    BrowserModule,
    HttpClientModule
  ],
  providers: [DataService],
  bootstrap: [AppComponent]
})
export class AppModule { }
