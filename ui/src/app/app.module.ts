import { ModuleWithProviders, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { AuthModule } from './auth/auth.module';
import { EditorModule } from './editor/editor.module';
import { HomeModule } from './home/home.module';
import { ProfileModule } from './profile/profile.module';
import { SettingsModule } from './settings/settings.module';
import { ArticleModule } from './article/article.module';

import { ApiService, UserService, FooterComponent, HeaderComponent, 
         JwtService, SharedModule, AuthGuard, ProfilesService, ArticlesService } from './shared';

const rootRouting: ModuleWithProviders = RouterModule.forRoot([], { useHash: true });

@NgModule({
  declarations: [
    AppComponent,
    FooterComponent,
    HeaderComponent
  ],
  imports: [
    BrowserModule,
    ArticleModule,
    AuthModule,
    HomeModule,
    ProfileModule,
    EditorModule,
    rootRouting,
    SharedModule,
    SettingsModule
  ],
  providers: [
    ApiService,
    UserService,
    JwtService,
    ProfilesService,
    ArticlesService,
    AuthGuard
  ],
  bootstrap: [AppComponent]
})
export class AppModule {}
