import { Pipe, PipeTransform } from '@angular/core';
@Pipe({name: 'imageSrc'})
export class ImageSrc implements PipeTransform {
  transform(src: string) : any {
    return `http://localhost:5000/images/${src}`;
  }
}