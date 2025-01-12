﻿using MST_Service.Entities;
using MST_Service.Repositories.Implementations;
using MST_Service.Repositories.Interfaces;

namespace MST_Service.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MstContext _context;

        public UnitOfWork(MstContext context)
        {
            _context = context;
        }

        private ILectureRepository _lecture = null!;

        public ILectureRepository Lecture
        {
            get { return _lecture ??= new LectureRepository(_context); }
        }

        private IGradeRepository _grade = null!;

        public IGradeRepository Grade
        {
            get { return _grade ??= new GradeRepository(_context); }
        }

        private IAddressRepository _address = null!;

        public IAddressRepository Address
        {
            get { return _address ??= new AddressRepository(_context); }
        }


        public IUserRepository _user = null!;
        public IUserRepository User
        {
            get { return _user ??= new UserRepository(_context); }
        }

        public ISubjectRepository _subject = null!;
        public ISubjectRepository Subject
        {
            get { return _subject ??= new SubjectRepository(_context); }
        }

        public IRoleRepository _role = null!;
        public IRoleRepository Role
        {
            get { return _role ??= new RoleRepository(_context); }
        }

        public IFeedbackRepository _feedback = null!;
        public IFeedbackRepository Feedback
        {
            get { return _feedback ??= new FeedbackRepository(_context); }
        }

        public IPaymentRepository _payment = null!;
        public IPaymentRepository Payment
        {
            get { return _payment ??= new PaymentRepository(_context); }
        }

        public IDocumentRepository _document = null!;
        public IDocumentRepository Document
        {
            get { return _document ??= new DocumentRepository(_context); }
        }

        public ISlotRepository _slot = null!;
        public ISlotRepository Slot
        {
            get { return _slot ??= new SlotRepository(_context); }
        }

        public IGenderRepository _gender = null!;
        public IGenderRepository Gender
        {
            get { return _gender ??= new GenderRepository(_context); }
        }
        private IDemandRepository _demand = null!;
        public IDemandRepository Demand
        {
            get { return _demand ??= new DemandRepository(_context); }
        }

        private IScheduleRepository _schedule = null!;
        public IScheduleRepository Schedule
        {
            get { return _schedule ??= new ScheduleRepository(_context); }
        }

        private ISyllabusRepository _syllabus = null!;
        public ISyllabusRepository Syllabus
        {
            get { return _syllabus ??= new SyllabusRepository(_context); }
        }

        private IPromotionRepository _promotion = null!;
        public IPromotionRepository Promotion
        {
            get { return _promotion ??= new PromotionRepository(_context); }
        }
        private ITransactionRepository _transaction = null!;
        public ITransactionRepository Transaction
        {
            get { return _transaction ??= new TransactionRepository(_context); }
        }

        private IWalletRepository _wallet = null!;
        public IWalletRepository Wallet
        {
            get { return _wallet ??= new WalletRepository(_context); }
        }
        private IEventRepository _event = null!;
        public IEventRepository Event
        {
            get { return _event ??= new EventRepository(_context); }
        }

        private IBookingStatusRepository _bookingStatus = null!;
        public IBookingStatusRepository BookingStatus
        {
            get { return _bookingStatus ??= new BookingStatusRepository(_context); }
        }
        
        private IBookingRepository _booking = null!;
        public IBookingRepository Booking
        {
            get { return _booking ??= new BookingRepository(_context); }
        }

        //private IGradeSyllabusRepository _gradeSyllabus = null!;
        //public IGradeSyllabusRepository GradeSyllabus
        //{
        //    get { return _gradeSyllabus ??= new GradeSyllabusRepository(_context); }
        //}
        //private ILectureDocumentRepository _lectureDocument = null!;
        //public ILectureDocumentRepository LectureDocument
        //{
        //    get { return _lectureDocument ??= new LectureDocumentRepository(_context); }
        //}
        //private ILectureGradeRepository _lectureGrade = null!;
        //public ILectureGradeRepository LectureGrade
        //{
        //    get { return _lectureGrade ??= new LectureGradeRepository(_context); }
        //}
        //private ILectureSubjectRepository _lectureSubject = null!;
        //public ILectureSubjectRepository LectureSubject
        //{
        //    get { return _lectureSubject ??= new LectureSubjectRepository(_context); }
        //}


        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
