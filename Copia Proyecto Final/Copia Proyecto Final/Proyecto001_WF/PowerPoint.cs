using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using A = DocumentFormat.OpenXml.Drawing;
using P = DocumentFormat.OpenXml.Presentation;

namespace Proyecto001_WF
{
    public class PowerPoint
    {
        public void CrearDocumentoPowerPoint(string ruta, string texto)
        {
            using (PresentationDocument presentationDoc = PresentationDocument.Create(ruta, DocumentFormat.OpenXml.PresentationDocumentType.Presentation))
            {
                PresentationPart presentationPart = presentationDoc.AddPresentationPart();
                presentationPart.Presentation = new Presentation();
                SlideIdList slideIdList = new SlideIdList();
                uint slideId = 256;

                string[] lineas = texto.Split('\n');

                foreach (var linea in lineas)
                {
                    var slidePart = presentationPart.AddNewPart<SlidePart>();
                    slidePart.Slide = new Slide(new CommonSlideData(new ShapeTree()));

                    var shapeTree = slidePart.Slide.CommonSlideData.ShapeTree;

                    // Cuadro de texto con el contenido de la línea
                    var shape = new Shape(
                        new NonVisualShapeProperties(
                            new NonVisualDrawingProperties() { Id = 1, Name = "Texto" },
                            new NonVisualShapeDrawingProperties(new A.ShapeLocks() { NoGrouping = true }),
                            new ApplicationNonVisualDrawingProperties()
                        ),
                        new ShapeProperties(
                            new A.Transform2D(
                                new A.Offset() { X = 914400, Y = 914400 }, // 1cm, 1cm
                                new A.Extents() { Cx = 6858000, Cy = 2000000 } // tamaño del cuadro
                            )
                        ),
                        new TextBody(
                            new A.BodyProperties(),
                            new A.ListStyle(),
                            new A.Paragraph(new A.Run(new A.Text(linea.Trim())))
                        )
                    );
                    shapeTree.Append(shape);

                    // Agregar fondo obligatorio
                    shapeTree.AppendChild(new P.Picture(
                        new P.NonVisualPictureProperties(
                            new P.NonVisualDrawingProperties() { Id = 2, Name = "Fondo" },
                            new P.NonVisualPictureDrawingProperties(),
                            new P.ApplicationNonVisualDrawingProperties()
                        ),
                        new P.BlipFill(),
                        new P.ShapeProperties()
                    ));

                    // Agregar la diapositiva a la presentación
                    string relId = presentationPart.GetIdOfPart(slidePart);
                    slideIdList.Append(new SlideId() { Id = slideId++, RelationshipId = relId });
                }

                presentationPart.Presentation.Append(slideIdList);
                presentationPart.Presentation.Save();
            }
        }
    }
}

