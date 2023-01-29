using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PaintingDescription : MonoBehaviour
{
    //optimisation de la collecte de donnees pour la prochaine fois passer par le lien internet des peintures 

    [SerializeField] private string[] artistName = { "Léonard de Vinci", "Vincent Van Gogh", "Edward Munch", "Claude Monet", "Diego Velázquez", "Frida Kahlo", "Rembrandt", "Gustav Klimt", "Alexandre Cabanel", "Pierre-Auguste Renoir", "Sandro Botticelli","" };   // nom artiste
    [SerializeField] private string[] artWorkName = { "La_Joconde_-_De_Vinci", "Van-Gogh.-La-nuit-etoilee", "le-cri-munch-1893", "Claude-Monet-Water-Lilies-or-Nympheas-", "Les_Mnines_Velasquez", "les_deux_fridas141870", "rembrandt-ronde-de-nuit", "Le_Baiser_-_Klimt", "Cabanel-Lange_dchu", "Pierre-Auguste_Renoir_-_Luncheon_of_the_Boating_Party_-_Google_Art_Project", "Sandro_Botticelli_-_La_nascita_di_Venere_-_Google_Art_Project_-_edited", "" }; // nom oeuvre (image)
    [SerializeField] private string[] description = { "La Joconde, également connue sous le nom de Mona Lisa, est une peinture à l'huile sur bois réalisée par Léonard de Vinci entre 1503 et 1506. Elle mesure 30 x 21 cm. Ce tableau est considéré comme l'un des chefs-d'œuvre de la peinture mondiale, et l'une des œuvres les plus célèbres de l'histoire de l'art. Il représente une jeune femme souriante, assise devant un paysage en arrière-plan. La Joconde est célèbre pour son sourire énigmatique et son utilisation innovante de la lumière et de l'ombre pour créer de la profondeur. Depuis sa création, il a été exposé dans de nombreux musées à travers le monde, et il est actuellement exposé au musée du Louvre à Paris.", "La Nuit Étoilée de Van Gogh est une peinture à l'huile sur toile créée en 1888. Il représente un paysage nocturne avec un ciel étoilé, des arbres et une route. Van Gogh a utilisé des couleurs vives et des traits de pinceau expressifs pour capturer l'émotion de cette scène. Il a été peint pendant son séjour à l'asile Saint-Paul-de-Mausole, à Saint-Rémy-de-Provence. Cette peinture est considérée comme l'un des chefs-d'œuvre de Van Gogh et de l'impressionnisme. Il a été réalisé en seulement une nuit, lorsque Van Gogh a été inspiré par les étoiles et la tranquillité de la nature qui l'entourait. Il a utilisé des couleurs vives pour représenter les étoiles et les arbres, créant ainsi un contraste saisissant entre la lumière et l'obscurité. Cette œuvre est considérée comme l'une des plus célèbres de Van Gogh, et est souvent considérée comme un symbole de la lutte de l'artiste pour se connecter à la nature.", "Le Cri de Munch est une peinture à l'huile sur toile créée en 1893. Il représente un homme qui crie, entouré d'un paysage déchirant et d'éléments symboliques tels que des mains qui se tendent vers lui. Munch a voulu exprimer l'angoisse et la solitude humaine à travers cette œuvre. Il a été peint pendant sa période symboliste et est considéré comme l'un des chefs-d'œuvre de l'expressionnisme. Il est devenu un symbole de l'angoisse moderne dans l'art, et a été interprété de différentes manières, comme un cri de désespoir face à la vie moderne ou un reflet de la solitude de l'individu moderne. Les couleurs utilisées sont sombres, reflétant l'humeur dépressives de l'artiste à cette époque. Le cri est surtout un symbole de l'angoisse, de la solitude et de l'incapacité à trouver sa place dans le monde.", "Les Nénuphars de Monet est une série de peintures à l'huile sur toile créée en 1899. Il représente des nénuphars flottant sur une étendue d'eau, avec un ciel nuageux en arrière-plan. Monet a utilisé des couleurs vives et des touches de pinceau pour capturer la lumière changeante de cette scène. Il a été peint pendant sa période impressionniste et est considéré comme l'un des chefs-d'œuvre de Monet. Il a peint cette série de tableaux en se concentrant sur les nénuphars qui poussent dans son jardin d'eau à Giverny. Il a utilisé des couleurs vives pour représenter les nénuphars, en utilisant des touches de pinceau pour créer un effet de mouvement et de profondeur. Il a également utilisé des couleurs pour capturer les variations de lumière et les reflets de l'eau. Les Nénuphars de Monet sont devenus l'un des symboles les plus connus de l'impressionnisme et de l'art moderne en général.", "Les Ménines de Velázquez est une peinture à l'huile sur toile réalisée en 1656. Elle représente la reine d'Espagne, Marie-Thérèse, et ses dames d'honneur, avec Velázquez lui-même peint en train de peindre le tableau dans le coin en bas à droite. Cette œuvre est considérée comme un des chefs-d'œuvre de la peinture espagnole, et l'une des œuvres les plus importantes de Velázquez. Il est reconnu pour son utilisation de la mise en scène, de la lumière et de la perspective pour créer une image complexe et riche de sens. Il est exposé au Musée du Prado à Madrid.", "Les Deux Fridas de Frida Kahlo est une peinture à l'huile sur toile réalisée en 1939. Elle représente deux versions de Frida Kahlo assises côte à côte, main dans la main, chacune vêtue de la tenue traditionnelle mexicaine. Le cœur de l'une d'elles est ouvert et relié par des veines à celui de l'autre. La peinture est considérée comme l'une des œuvres les plus importantes de Frida Kahlo et reflète sa propre expérience personnelle et ses émotions. Elle est vue comme un symbole de l'autoréflexion et de l'identité personnelle. Elle est souvent interprétée comme une représentation de la dualité de Frida Kahlo en tant qu'individu et de son identification comme une femme mexicaine. Les couleurs utilisées sont vives, reflétant l'énergie de Frida Kahlo.", "La Ronde de Nuit de Rembrandt est une peinture à l'huile sur toile réalisée en 1642. Elle représente une scène de rue nocturne avec des personnages habillés en costumes de l'époque, dont un personnage principal qui tient une lanterne. La peinture est considérée comme l'une des œuvres les plus importantes de Rembrandt et est reconnue pour son utilisation innovante de la lumière pour créer une atmosphère dramatique et réaliste. Le tableau est vu comme une représentation de la vie quotidienne de l'époque et de l'humanité commune. Les couleurs utilisées sont sombres, reflétant l'ambiance nocturne de la scène. La Ronde de Nuit de Rembrandt est souvent considérée comme un chef-d'œuvre de l'utilisation de la lumière dans l'art et est exposée dans les musées à travers le monde.", "Le Baiser de Klimt est une peinture à l'huile sur toile réalisée en 1908. Il représente un couple en train de s'embrasser, entouré d'un décor luxuriant et de motifs ornementaux. La peinture est considérée comme l'une des œuvres les plus importantes de Klimt et est reconnue pour son utilisation innovante de la couleur, de la forme et des motifs pour créer une image sensuelle et érotique. Il est souvent considéré comme une représentation de l'amour et de la passion. Il a été peint pendant sa période Art nouveau, où il a développé un style original, qui mélange des éléments de l'art byzantin, des motifs traditionnels viennois et des influences japonisantes. Le Baiser de Klimt est souvent considéré comme un symbole de l'émancipation des femmes et de la libération sexuelle.", "L'Ange Déchu de Cabanel est une peinture à l'huile sur toile réalisée en 1863. Il représente un ange déchu, nu, entouré d'un décor romantique et dramatique. La peinture est considérée comme l'une des œuvres les plus importantes de Cabanel et est reconnue pour son utilisation innovante de la couleur, de la forme et des motifs pour créer une image sensuelle et érotique. Il est souvent considéré comme une représentation de la chute de l'ange et de la perte de l'innocence. Il a été peint pendant une période où le romantisme était en vogue, et reflète les thèmes romantiques tels que la nature, l'émotion et le mysticisme. L'Ange Déchu de Cabanel est souvent considéré comme un symbole de la condition humaine et de la prise de conscience de la faiblesse et de la vulnérabilité.", "Le Déjeuner des Canotiers de Renoir est une peinture à l'huile sur toile réalisée en 1881. Il représente un groupe de personnes, principalement des femmes, dans un bateau à rames, en train de déjeuner. La peinture est considérée comme l'une des œuvres les plus importantes de Renoir et est reconnue pour son utilisation innovante de la couleur, de la forme et des motifs pour créer une image joyeuse et ensoleillée. Il a été peint pendant sa période impressionniste, où il a développé un style original, qui mélange des éléments de l'art traditionnel et des influences modernes. Il a utilisé des couleurs vives pour représenter les personnages et les paysages, créant ainsi un contraste saisissant entre la lumière et l'ombre. Le Déjeuner des Canotiers de Renoir est souvent considéré comme un symbole de la vie joyeuse et de l'insouciance de la fin du XIXe siècle.", "La Naissance de Vénus de Botticelli est une peinture à l'huile sur toile réalisée vers 1485. Il représente la déesse Vénus sortant de l'eau, entourée de personnages allégoriques et de décors inspirés de la mythologie antique. La peinture est considérée comme l'une des œuvres les plus importantes de Botticelli et est reconnue pour son utilisation innovante de la forme, de la couleur et des motifs pour créer une image sensuelle et érotique. Il est souvent considéré comme une représentation de la beauté féminine et de la sensualité. Il a été peint pendant la Renaissance italienne, où l'art était fortement influencé par les thèmes de l'Antiquité classique. La Naissance de Vénus de Botticelli est souvent considérée comme un symbole de l'épanouissement de la femme et de la libération sexuelle.", "" }; // descriptif oeuvre 

    [SerializeField] private Image targetImage;
    

   // private int currentImageIndex = 0;
    public Text descriptionText;


    // Start is called before the first frame update
    void Start()
    {    // chargement des images 
      //  targetImage.sprite = Resources.Load<Sprite>("Images/" + artWorkName[currentImageIndex]);
     
    }

    // Update is called once per frame
    void Update()
    {

    }



   /* public void ShowNextImage()
    {
        // limite de ce code est que dès que cela dépasse l'index prédéfini on revient à l'index 0
        currentImageIndex++;
        if (currentImageIndex >= artWorkName.Length)
        {
            currentImageIndex = 0;
        }

        // chargement du sprite en utilisant resources Load pour le definir comme targetImage
        Sprite sprite = Resources.Load<Sprite>("Images/" + artWorkName[currentImageIndex]);
        targetImage.sprite = sprite;

        descriptionText.text = description[currentImageIndex];
    }*/


}
