using Microsoft.AspNetCore.Mvc;

namespace Academia_De_Idiomas.Controllers
{
    public class IdiomasController : Controller
    {
        public IActionResult Idiomas(string idioma)
        {
            ViewBag.idioma = idioma;

            if (idioma == "Ingles")
            {
                ViewBag.parrafo = $"Podras  escoger entre una amplia gama de clases de {idioma}, tanto virtuales como presenciales." +
                    "Te ofrecemos la máxima flexibilidad para que puedas integrar un curso de inglés en tu vida, por más ocupada que sea." +
                    "Empieza a conversar Inglés desde la primera clase y domina el idioma en tiempo récord.";
                ViewBag.parrafo2 = "Empieza a conversar Inglés desde la primera clase y domina el idioma en tiempo récord.";

                List<string> Beneficios = new List<string>()
                {
                    "Entenderas el idioma más hablado del mundo", "Mejores oportunidades laborales", "Estudiar en Estados Unidos", "Emigrar"
                };
                ViewBag.Beneficios = Beneficios;
                return View();
            }
            else if (idioma == "Español")
            {
                ViewBag.parrafo = $"Aprene a hablar {idioma} como un nativo con nuestros métodos. Combinando la comprensión con las habilidades" +
                    "lingüísticas, serás capaz de comunicarte con confianza y de manera eficaz en cualquier situación.";

                List<string> Beneficios = new List<string>()
                {
                    "Es uno de los idiomas con más hablantes en el mundo", "Mejores oportunidades laborales", "Viajes a Latinoamerica y España", "Conocer nuevas personas", "Aprender español te facilitará aprender otros idiomas"
                };
                ViewBag.Beneficios = Beneficios;
            }
            else if (idioma == "Frances")
            {
                ViewBag.parrafo = "Sumergete de lleno en el Francés con clases impartidas exclusivamente en el idioma por instructores altamente" +
                    "cualificados. Ya sea porque necesitas aprender francés, por cuestiones laborales, tienes algún viaje planeado, porque quieres" +
                    "irte a estudiar al extranjero o simplemente por placer, aquí te ofrecemos cursos completamente personalizados para ayudarte a lograr tus objetivos.";

                List<string> Beneficios = new List<string>()
                {
                    "Comunicarte fácilmente con los nativos", "Conocer su país", "Idioma oficial de organizaciones internacionales", "Mejores oportunidades laborales"
                };
                ViewBag.Beneficios = Beneficios;
            }
            else if (idioma == "Aleman")
            {
                ViewBag.parrafo = "Desarrolla la fluidez de un nativo con los cursos en Alemán. A través de nuestros métodos, no solo aprenderás a" +
                    "hablar alemán, sino que también aprenderás los aspectos culturales que te permitirán un dominio total del idioma. Ya sea porque" +
                    "quieres aprender este idioma por cuestiones de trabajo, viajes o sociales, te ofrecemos la forma más rápida y efectiva para ayudarte a lograr tus objetivos.";

                List<string> Beneficios = new List<string>()
                {
                    "Aprender el idioma más hablado de Europa", "Facilidad de aprendizaje", "Trabajo en Alemania", "Vivir en Alemania"
                };
                ViewBag.Beneficios = Beneficios;
            }
            else if (idioma == "Italiano")
            {
                ViewBag.parrafo = $"Cuando aprendes {idioma}, el conocimiento de sus matices culturales es tan importante como entender el propio" +
                    "idioma. Con nosotros no solo desarrollaras tus habilidades lingüísticas, sino que además te sumergiras en la cultura italiana." +
                    "Esto te dará un dominio total del idioma y te hará capaz de comunicarte de manera eficaz en situaciones cotidianas y profesionales.";

                List<string> Beneficios = new List<string>()
                {
                    "Conocer la capital de la moda y diseño", "Un sitio perfecto para viajar", "Vivir o trabajar en Italia", "Aprende el lenguaje no hablado"
                };
                ViewBag.Beneficios = Beneficios;
            }
            else if (idioma == "Japones")
            {
                ViewBag.parrafo = "Gracias a nuestros métodos desarrollarás la fluidez cultural necesaria para comunicarte con confianza y de forma" +
                    "eficaz en japonés, tanto en situaciones  sociales como profesionales.";
                ViewBag.parrafo2 = "Si quieres crear nuevas oportunidades de negocio, tener un viaje o simplemente conocer más sobre está cultura" +
                    "milenaria, aquí encontrarás clases de japonés que se ajustan a tus necesidades y objetivos.";

                List<string> Beneficios = new List<string>()
                {
                    "Poder viajar a Japón", "Estudiar, trabajar y poder vivir en Japón", "Facilidad de aprender otros idiomas asiáticos", "Mejores oportunidades de negocio"
                };
                ViewBag.Beneficios = Beneficios;
            }
            else if (idioma == "Ruso")
            {
                ViewBag.parrafo = $"Gracias a nuestros métodos dominaras el {idioma} en menos tiempo del que te imaginas. A través de la inmersión total," +
                    $"estarás practicando el ruso de manera activa desde la primera clase.";
                ViewBag.parrafo2 = "Con el apoyo de nuestros instructores irás desarrollando tus habilidades y adquiriendo nuevos conocimientos, además" +
                    "de un entendimiento cultural que te ayudará a dominar el idioma.";

                List<string> Beneficios = new List<string>()
                {
                    "Conocer Rusia", "Oportunidad laboral", "Reto de aprendizaje", "Te abre puertas a otros idiomas", "Oportunidades de estudio"
                };
                ViewBag.Beneficios = Beneficios;
            }
            else
            {
                ViewBag.parrafo = "En nuestra Academia conseguirás un buen dominio del portugués, ya que no solo aprenderás sus fundamentos lingüísticos, sino que " +
                    "además aprenderás sobre su cultura. Serás capaz de comunicarte con confianza y de forma efectiva en cualquier situación, tanto social como profesional.";
                ViewBag.parrafo2 = "Nuestras clases de portugués se enfocan en la conversación y empleamos un método para la inmersión total en el idioma, así que estarás " +
                    "comunicandote en portugués desde el comienzo. Se ha comprobado que este método es el más rápido y efectivo para desarrollar fluidez en el idioma.";

                List<string> Beneficios = new List<string>()
                {
                    "Idioma fácil de aprender", "Conocer Portugal y Brasil", "Trabaja en otro país", "Conoce sus culturas"
                };
                ViewBag.Beneficios = Beneficios;
            }

            return View();
        }
    }
}
